---Create Tables
CREATE TABLE categories(code int identity primary key, name varchar(20))
CREATE TABLE food(code int identity primary key,name varchar(20), description varchar(50), price int, cook_time int, category_code int foreign key references categories(code))
CREATE TABLE orders(code int identity primary key, food_name varchar(20), food_code int foreign key references food(code), table_num int, is_ready bit, category_name varchar(20))

---Show All Tables
select * from categories
select * from food
select * from orders

---Insert Category
INSERT INTO categories VALUES('Drinks')

---Insert Food
INSERT INTO food VALUES('Salmon', 'BAD MEAL', 110, 50, (select code from categories where name = 'Fish'))

---Insert Order
INSERT INTO orders VALUES('Beef', (select code from food where name = 'Beef'), 8, 0, (select name from categories where code = (select category_code from food where name = 'Meat')) )

---Get Orders
SELECT code, table_num, category_name, food_name from orders where is_ready = 0

---Change Order status
UPDATE orders SET is_ready = 1 WHERE code = 6