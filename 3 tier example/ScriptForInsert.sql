     
CREATE PROCEDURE [sprocUserinfoInsertUpdateSingleItem]    
(    
  
@Name nvarchar(50)=NULL    
,@Address nvarchar(100)=NULL    
,@EmailID nvarchar=NULL    
,@Mobilenumber varchar(10)=NULL    
    
)    
AS    
  
BEGIN    
    
 INSERT    
 INTO [Userinfo]    
 (    
  Name    
,Address    
,EmailID    
,Mobilenumber    
    
 )    
  VALUES    
  (    
  @Name    
,@Address    
,@EmailID    
,@Mobilenumber    
    
 )    
   SELECT SCOPE_IDENTITY()  
end  