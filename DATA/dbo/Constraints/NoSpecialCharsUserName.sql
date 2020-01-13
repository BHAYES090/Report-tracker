ALTER TABLE dbo.InterReport
ADD CONSTRAINT ck_No_Special_Characters 
       CHECK (UserNameEmailAddress NOT LIKE '%[^A-Z0-9]%')