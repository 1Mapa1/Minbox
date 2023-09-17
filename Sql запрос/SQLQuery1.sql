Select
    P.Name as Product,
    C.Name as Category
From
    Products as P
Left Join
    ProductCategory as PC on P.Id = PC.ProductId
Left Join
    Categories as C on PC.CategoryId = C.Id;