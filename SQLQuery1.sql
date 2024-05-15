SELECT * FROM users

INSERT INTO users (id, username, password, role, status, date, email)
VALUES (1, 'Admin', 'garten12', 'Admin', 'Aktif','renasayin1@gmail.com');

INSERT INTO users(username, password, role, status, email) 
VALUES ('admin1', 'garten12','Yonetici ','Aktif','renasayin1@gmail.com');

DELETE FROM users where ID = 26

select * from products

CREATE TABLE orders
(
id int PRIMARY KEY IDENTITY(1,1),
prod_id VARCHAR(MAX) NULL,
prod_name VARCHAR(MAX) NULL,
category VARCHAR(MAX) NULL,
qty INT NULL,
orig_price FLOAT NULL,
total_price FLOAT NULL,
order_date DATE NULL
)

SELECT * FROM orders
ALTER TABLE orders
add  customer_id INT NULL

CREATE TABLE customers
(
id int PRIMARY KEY IDENTITY(1,1),
customer_id INT NULL,
prod_id VARCHAR(MAX) NULL,
total_price FLOAT NULL,
amount FLOAT NULL,
change FLOAT NULL,
order_date DATE NULL
)

select * from customers