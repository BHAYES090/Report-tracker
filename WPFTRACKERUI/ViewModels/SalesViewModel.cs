using Caliburn.Micro;
using RTDesktopUI.Library.API;
using RTDesktopUI.Library.Helpers;
using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTRACKERUI.ViewModels
{
    public class SalesViewModel : Screen
    {
		IProductEndpoint _productEndpoint;
		IConfigHelper _configHelper;
		ISaleEndpoint _saleEndpoint;
		
		public SalesViewModel(IProductEndpoint productEndpoint, IConfigHelper configHelper, ISaleEndpoint saleEndpoint)
		{
			_productEndpoint = productEndpoint;
			_configHelper = configHelper;
			_saleEndpoint = saleEndpoint;
		}

		protected override async void OnViewLoaded(object view)
		{
			base.OnViewLoaded(view);
			await LoadProducts();
		}

		private async Task LoadProducts()
		{
			var productList = await _productEndpoint.GetAll();
			Products = new BindingList<ProductModel>(productList);
		}

		private BindingList<ProductModel> _products;

		public BindingList<ProductModel> Products
		{
			get { return _products; }
			set 
			{ 
				_products = value;
				NotifyOfPropertyChange(() => Products);
			}
		}
		private ProductModel _selectedProduct;

		public ProductModel SelectedProduct
		{
			get { return _selectedProduct; }
			set 
			{
				_selectedProduct = value;
				NotifyOfPropertyChange(() => SelectedProduct);
				NotifyOfPropertyChange(() => CanAddToCart);
			}
		}
		private BindingList<CartItemModel> _cart = new BindingList<CartItemModel>();

		public BindingList<CartItemModel> Cart 
		{
			get { return _cart; }
			set
			{
				_cart = value;
				NotifyOfPropertyChange(() => Cart);
			}
		}

		private int _itemQuantity = 1;

		public int ItemQuantity
		{
			get { return _itemQuantity; }
			set
			{
				_itemQuantity = value;
				NotifyOfPropertyChange(() => ItemQuantity);
				NotifyOfPropertyChange(() => CanAddToCart);
			}
		}

		public string SubTotal
		{
			get 
			{
				return CalculateSubTotal().ToString("C");
			}
		}

		private decimal CalculateSubTotal()
		{
			decimal subtotal = 0;
			foreach (var item in Cart)
			{
				subtotal += (item.Product.RetailPrice * item.QuantityInCart);
			}
			return subtotal;
		}

		public string Tax
		{
			get
			{
				return CalculateTax().ToString("C");
			}
		}
		private decimal CalculateTax()
		{
			decimal taxAmount = 0;
			decimal taxRate = _configHelper.GetTaxRate()/100;

			taxAmount = Cart
				.Where(x => x.Product.IsTaxable)
				.Sum(x => x.Product.RetailPrice * x.QuantityInCart * taxRate);

			//foreach (var item in Cart)
			//{
			//	if (item.Product.IsTaxable)
			//	{
			//		taxAmount += (item.Product.RetailPrice * item.QuantityInCart * taxRate);
			//	}
			//}

			return taxAmount;
		}
		public string Total
		{
			get
			{
				decimal total = CalculateSubTotal() + CalculateTax();
				return total.ToString("C");
			}
		}

		public bool CanAddToCart
		{
			get 
			{
				bool output = false;

				//Make sure something is selected 
				//make sure there is an item quantity
				if (ItemQuantity > 0 && SelectedProduct?.QuantityInStock >= ItemQuantity)
				{ 
					output = true;
				}
				return output;
			}
			
		}

		public void AddToCart()
		{
			CartItemModel existingItem = Cart.FirstOrDefault(x => x.Product == SelectedProduct);

			if (existingItem != null)
			{
				existingItem.QuantityInCart += ItemQuantity;
				// HACK - There is a better method
				Cart.Remove(existingItem);
				Cart.Add(existingItem);
			}
			else
			{
				CartItemModel item = new CartItemModel
				{
					Product = SelectedProduct,
					QuantityInCart = ItemQuantity
				};
				Cart.Add(item);
			}
			
			SelectedProduct.QuantityInStock -= ItemQuantity;
			ItemQuantity = 1;
			NotifyOfPropertyChange(() => SubTotal);
			NotifyOfPropertyChange(() => Tax);
			NotifyOfPropertyChange(() => Total);
			NotifyOfPropertyChange(() => CanCheckOut);
		}
		public bool CanremoveFromCart
		{
			get
			{
				bool output = false;

				//Make sure something is selected 
				//make sure there is an item quantity

				return output;
			}

		}

		public void RemoveFromCart()
		{
			NotifyOfPropertyChange(() => SubTotal);
			NotifyOfPropertyChange(() => Tax);
			NotifyOfPropertyChange(() => Total);
			NotifyOfPropertyChange(() => CanCheckOut);
		}
		public bool CanCheckOut
		{
			get
			{
				bool output = false;

				//Make sure something is in the cart
				if (Cart.Count > 0)
				{
					output = true;
				}

				return output;
			}

		}

		public async Task CheckOut()
		{
			// create sale model and post to API
			SaleModel sale = new SaleModel();
			
			foreach (var item in Cart)
			{
				sale.SaleDetails.Add(new SaleDetailModel
				{
					ProductId = item.Product.Id,
					Quantity = item.QuantityInCart
				});
			}
			await _saleEndpoint.PostSale(sale);
		}
	}
}
