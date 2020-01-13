ALTER TABLE dbo.InterReport
ADD CONSTRAINT ck_No_Special_Characters2
       CHECK (CommentBox NOT LIKE '%[^A-Z0-9]%')