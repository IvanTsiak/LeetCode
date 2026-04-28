SELECT name
FROM SalesPerson
WHERE name NOT IN(
    SELECT SalesPerson.name
    FROM SalesPerson, Orders, Company
    WHERE SalesPerson.sales_id=Orders.sales_id and Orders.com_id = Company.com_id and Company.name = 'RED'
)