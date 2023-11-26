SELECT p.name AS Product_Name, 
       c.name AS Category_Name
FROM products p 
LEFT JOIN categoryProductXRef cpxr 
  ON cpxr.productId = p.id
Left JOIN categories c 
  ON cpxr.categoryId = c.id
  Order By Category_Name