SELECT name AS Customers
FROM Customers
WHERE NOT EXISTS(
    SELECT *
    FROM Orders
    WHERE Customers.id = Orders.customerId
)