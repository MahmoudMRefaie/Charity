DROP DATABASE Charity;
CREATE DATABASE Charity;
USE Charity;
  
CREATE TABLE Login_User(
user_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
username VARCHAR(30) UNIQUE NOT NULL,
user_password VARCHAR(30),
user_type VARCHAR(20)
);

#SHOW TABLES;

INSERT INTO Login_user VALUES(1,"mahmoud","mahmoud","admin");
INSERT INTO Login_user VALUES(2,"ahmed","ahmed","volunteer");

#UPDATE Login_User SET user_type = "admin" WHERE user_id = 1;

SELECT * FROM Login_User;

CREATE TABLE State(
state_id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
state_name NVARCHAR(30) NOT NULL, #CHARACTER SET utf8 NOT NULL,
state_SSN VARCHAR(30) UNIQUE,
state_phone VARCHAR(15) UNIQUE,
state_age INT,
state_address NVARCHAR(100), #CHARACTER SET utf8,
state_gender NVARCHAR(5), #CHARACTER SET utf8,
state_health NVARCHAR(100),
state_income NVARCHAR(100),
state_social NVARCHAR(20), #CHARACTER SET utf8,
spouse_name NVARCHAR(255),
spouse_SSN varchar(30) UNIQUE,
state_children_num INT
);

INSERT INTO State VALUES(1,"Omar Ahmed","123456","0110011", 40, "El-Rozikat", "Male", "patient", "500","Single","Asmaa Ahmed", "44324234", 0);
INSERT INTO State VALUES(2,"Hassan Asaad","1234567890","010000011", 50, "El-Rozikat", "Male", "صحيح", "500","أرمل",NULL, NULL, 3);
INSERT INTO State VALUES(3,"حمد محمد احمد محمد","4009324","0128434", 50, "الرزيقات بحرى", "ذكر", "مريض", "300","متزوج","آيه أحمد", "432124324234", 2);
INSERT INTO State VALUES(4,'فاطمة محمد',"431251345","12335456", 45, 'ارمنت - الرزيقات بحرى', "أنثى", "صحيح", "300", "أرملة", NULL, NULL, 1);
INSERT INTO State VALUES(5,'على محمد محمد احمد',"4009111324","0122228434", 50, 'ارمنت - الرزيقات بحرى - الكوبرى', "ذكر", "صحيح", "600", "ارزقى", "زينب احمد", "334234234", 3);

SELECT * FROM State;

SELECT state_name AS 'الاسم' ,state_SSN AS 'الرقم القومى' ,state_phone AS 'رقم الهاتف' ,state_age AS 'العمر'  ,state_address AS 'العنوان' ,state_gender AS 'النوع' ,state_social AS 'الحالة الاجتماعية' ,state_children_num AS 'عدد اطفاله' FROM State;

CALL ShowData();

delimiter //
CREATE PROCEDURE ShowData()
begin
SELECT state_id AS 'الترتيب', state_name AS 'الاسم' ,state_SSN AS 'الرقم القومى' ,state_phone AS 'رقم الهاتف' ,state_age AS 'العمر'  ,state_address AS 'العنوان' ,state_gender AS 'النوع', state_health AS 'الحالة الصحية', state_income AS 'الدخل',state_social AS 'الحالة الاجتماعية' , spouse_name AS 'اسم الزوجة', spouse_SSN AS 'الرقم القومى للزوجة', state_children_num AS 'عدد اطفاله' FROM State;
end;//
delimiter;
delimiter //

CREATE PROCEDURE ShowWidowers_Data()
begin
SELECT state_id AS 'ID', state_name AS 'Name' ,state_SSN AS SSN ,state_phone AS 'Phone number' ,state_age AS 'Age'  ,state_address AS 'Address' ,state_gender AS 'Gender',state_income AS 'Income' , state_health AS 'Health Status' ,state_social AS 'Social state',spouse_name AS 'Wife Name' ,spouse_SSN AS 'Wife SSN' ,state_children_num AS 'Children Number' FROM State WHERE state_social LIKE '%رمل%';
end;//
delimiter;
delimiter //

CALL ShowWidowers_Data();
