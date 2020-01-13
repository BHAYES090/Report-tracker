ALTER TABLE dbo.InterReport
ADD CONSTRAINT ck_No_Special_Characters1
       CHECK (PhoneNumber NOT LIKE '%[^A-Z0-9]%')
