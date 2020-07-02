CREATE DATABASE QLGSFinal

USE QLGSFinal

--CREATE TABLE
CREATE TABLE TUTOR 
(
	idTutor INT IDENTITY (100000,1) PRIMARY KEY,
	userName NCHAR(20) UNIQUE,
	password NCHAR(20),
	accountType INT DEFAULT(1),
	name NVARCHAR(30),
	phone CHAR(10),
	email NCHAR(30) UNIQUE,
	identityNumber CHAR(9) UNIQUE,
	gender NVARCHAR(3),
	birth NVARCHAR(12),
	address NVARCHAR(30),
	status INT,
	title NVARCHAR(10),
	workPlace NVARCHAR(50),
	description NVARCHAR(500),
	pic image
)

CREATE TABLE TUITION
(
	idTuition INT IDENTITY (200001,1),
	idTutor INT,
	Subject NVARCHAR(10),
	Grade NVARCHAR(3),
	tuition FLOAT
)

CREATE TABLE LEARNTIME
(
	idLearnTime INT IDENTITY (300001,1),
	idTutor INT,
	session NVARCHAR(10),
	day NVARCHAR(10)
)

CREATE TABLE COURSE
(
	idCourse INT IDENTITY (400001,1),
	idTutor INT,
	nameOfParents NVARCHAR(30),
	phoneOfParents VARCHAR(11),
	realTuition INT,
	signUpDate DATE
)

--INSERT FOREIGN KEY
ALTER TABLE dbo.COURSE
 ADD CONSTRAINT fk_id_tutor
   FOREIGN KEY (idTutor)
   REFERENCES dbo.TUTOR(idTutor)
   ON DELETE CASCADE
   ON UPDATE CASCADE;

ALTER TABLE dbo.LEARNTIME
 ADD CONSTRAINT fk_id_tutor1
   FOREIGN KEY (idTutor)
   REFERENCES dbo.TUTOR(idTutor)
   ON DELETE CASCADE
   ON UPDATE CASCADE;

ALTER TABLE dbo.TUITION
 ADD CONSTRAINT fk_id_tutor2
   FOREIGN KEY (idTutor)
   REFERENCES dbo.TUTOR(idTutor)
   ON DELETE CASCADE
   ON UPDATE CASCADE;


--INSERT DATA

--ADMIN INSERT FIRST
INSERT INTO TUTOR (userName, password, accountType, status) VALUES ('admin', 'admin', 0, 1)
UPDATE TUTOR SET pic = (SELECT  BulkColumn FROM OPENROWSET(BULK N'E:\DACNPM\image\admin.jpg', SINGLE_BLOB) AS img) WHERE userName = 'admin'

--
insert into TUTOR(name, userName, password, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description,pic) 
SELECT N'Nguyễn Kim Huy', 'huy','1', '0929153269', 'nguyenkimhuy@gmail.com', 191965881, N'Nam', 1999, N'Hải Châu', 1, N'Sinh viên', N'Đại học Bách Khoa Đà Nẵng', N'Giới thiệu ngắn về Huy', BulkColumn 
FROM Openrowset( Bulk 'E:\DACNPM\image\01.jpg', Single_Blob) as img

insert into TUTOR(name, userName, password, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description,pic) 
SELECT N'Văn Ngọc Đạt', 'dat', '1', '0365867652', 'vanngocdat@gmail.com', 191965869, N'Nam', 2000, N'Liên Chiểu', 1, N'Sinh viên', N'Đại học Bách Khoa Đà Nẵng', N'Giới thiệu ngắn về Đạt', BulkColumn 
FROM Openrowset( Bulk 'E:\DACNPM\image\02.jpg', Single_Blob) as img 

insert into TUTOR(name, userName, password, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description, pic) 
SELECT N'Hoàng Nguyên Vũ', 'vu', '1', '0929153196', 'hoangnguyenvu@gmail.com', 191965123, N'Nữ', 1969, N'Hải Châu', 1, N'Giảng viên', N'Đại học Bách Khoa Đà Nẵng', N'Giới thiệu ngắn về Vũ', BulkColumn 
FROM Openrowset( Bulk 'E:\DACNPM\image\03.jpg', Single_Blob) as img 

insert into TUTOR(name, userName, password, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description, pic) 
SELECT N'Trần Ngọc Huy', 'ngochuy', '1', '0929151233', 'tranngochuy@gmail.com', 191569623, N'Nam', 2000, N'Liên Chiểu', 1, N'Sinh viên', N'Đại học Sư Phạm Đà Nẵng', N'Giới thiệu ngắn về Huy', BulkColumn 
FROM Openrowset( Bulk 'E:\DACNPM\image\04.jpg', Single_Blob) as img 

insert into TUTOR(name, userName, password, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description, pic) 
SELECT N'Võ Văn Mười', 'muoi', '1', '0829151233', 'vovanmuoi@gmail.com', 201969623, N'Nam', 1990, N'Thanh Khê', 1, N'Giảng viên', N'Đại học Sư Phạm Đà Nẵng', N'Giới thiệu ngắn về Mười', BulkColumn 
FROM Openrowset( Bulk 'E:\DACNPM\image\05.jpg', Single_Blob) as img 

insert into TUTOR(name, userName, password, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description, pic) 
SELECT N'Nguyễn Lê Tuấn Cương', 'cuong', '1', '0129151233', 'cuong@gmail.com', 201969423, N'Nữ', 1985, N'Hải Châu', 1, N'Giảng viên', N'Đại học Kinh tế Đà Nẵng', N'Giới thiệu ngắn về Cương', BulkColumn 
FROM Openrowset( Bulk 'E:\DACNPM\image\06.jpg', Single_Blob) as img 

INSERT INTO TUITION (idTutor, Subject, Grade, tuition) VALUES
('100001', 'Hóa', '12', 950000),
('100001', 'Toán', '10', 800000),
('100001', 'Toán', '11', 850000),
('100001', 'Toán', '12', 900000),
('100002', 'Toán', '8', 700000),
('100002', 'Lý', '8', 800000),
('100002', 'Hóa', '9', 850000),
('100002', 'Toán', '10', 850000),
('100003', 'Hóa', '8', 800000),
('100003', 'Hóa', '9', 900000),
('100003', 'Hóa', '10', 900000),
('100003', 'Hóa', '11', 950000),
('100004', 'Sinh', '6', 600000),
('100004', 'Lý', '9', 900000),
('100004', '', '', 0),
('100004', '', '', 0),
('100005', 'Sinh', '6', 600000),
('100005', 'Lý', '9', 900000),
('100005', '', '', 0),
('100005', '', '', 0),
('100006', 'Sinh', '6', 600000),
('100006', 'Lý', '9', 900000),
('100006', '', '', 0),
('100006', '', '', 0)

INSERT INTO LEARNTIME (idTutor, session, day) VALUES
('100003', N'Tối', N'Thứ 2'),
('100003', N'Tối', N'Thứ 3'),
('100003', N'Tối', N'Thứ 4'),
('100003', N'Sáng', N'Thứ 7'),
('100003', N'Chiều', N'Thứ 7'),
('100003', N'Tối', N'Thứ 7'),
('100003', N'Sáng', N'Chủ nhật'),
('100003', N'Chiều', N'Chủ nhật'),
('100003', N'Tối', N'Chủ nhật'),
('100001', N'Tối', N'Thứ 2'),
('100001', N'Tối', N'Thứ 3'),
('100001', N'Tối', N'Thứ 4'),
('100001', N'Sáng', N'Chủ nhật'),
('100002', N'Tối', N'Thứ 2'),
('100002', N'Sáng', N'Thứ 3'),
('100002', N'Chiều', N'Thứ 4'),
('100002', N'Tối', N'Chủ nhật')

INSERT INTO COURSE (idTutor, nameOfParents, phoneOfParents, realTuition, signUpDate) VALUES
('100001', N'Trần Thị Thủy', '0375612348', 800000, '2020-05-06'),
('100002', N'Phan Văn Hiếu', '0375456348', 800000, '2020-05-07'),
('100003', N'Trần Văn Phong', '0375612312', 850000, '2020-05-10'),
('100005', N'Nguyễn Thanh Tùng', '0375612387', 900000, '2020-06-02')


------------------------------------------------------------------------------------------

--QUERY

SELECT idTutor as [ID], name as [Họ tên], userName as [Tài khoản], password as [Mật khẩu], phone as [SĐT], address as [Địa chỉ], identityNumber as [CMND] FROM TUTOR

SELECT idTutor FROM TUTOR
select * from TUTOR WHERE name LIKE N'%đạt%'
select * from COURSE
select * from LEARNTIME
select * from TUITION

DELETE FROM TUTOR WHERE idTutor = 100002;

SELECT * FROM TUITION WHERE idTutor = 100001
SELECT * FROM TUITION WHERE idTutor = 100002
SELECT * FROM TUITION WHERE idTutor = 100003
SELECT * FROM TUITION WHERE idTutor = 100005

SELECT * FROM LEARNTIME WHERE idTutor = 100001
SELECT * FROM LEARNTIME WHERE idTutor = 100002
SELECT * FROM LEARNTIME WHERE idTutor = 100005

SELECT idCourse as [ID Khóa học], TUTOR.idTutor as [ID Gia sư], name as [Tên gia sư] , TUTOR.phone as [SĐT gia sư], nameOfParents as [Tên phụ huynh], phoneOfParents as [SĐT phụ huynh], realTuition as [Học phí], signUpDate as [Ngày đăng ký] FROM COURSE, TUTOR 
WHERE COURSE.idTutor = TUTOR.idTutor AND signUpDate >= '20200507' AND signUpDate <= '20200605'

--LOAD COMBO BOX
SELECT DISTINCT Grade FROM TUITION ORDER BY Grade ASC
SELECT DISTINCT Subject FROM TUITION ORDER BY Subject ASC
SELECT DISTINCT title FROM TUTOR


--TIM KIEM
SELECT TUTOR.idTutor FROM TUTOR INNER JOIN TUITION ON TUTOR.idTutor = TUITION.idTutor
WHERE TUITION.Subject = N'Hóa'
SELECT DISTINCT TUTOR.idTutor FROM TUTOR INNER JOIN TUITION ON TUTOR.idTutor = TUITION.idTutor
WHERE TUITION.Subject = N'Hóa' AND TUITION.Grade = '9' AND TUTOR.gender = N'Nam'
SELECT * FROM TUTOR WHERE idTutor = 100001 OR idTutor = 100002


--TUITION
INSERT INTO TUITION (idTutor, Subject, Grade, tuition) VALUES
('100001', '', '', 0)
UPDATE TUITION SET Subject = N'Hóa', tuition = 900000  WHERE idTuition = 100001
SELECT * FROM TUITION WHERE idTutor = 100001
SELECT idTutor FROM TUTOR WHERE userName = 'ha'

--LEARNTIME

SELECT * FROM LEARNTIME WHERE idTutor = 100001
INSERT INTO LEARNTIME (idTutor, session, day) VALUES
('1000001', N'Sáng', N'Thứ 6')

DELETE FROM LEARNTIME WHERE idTutor = 100001 AND session = N'Sáng' AND day = N'Thứ 5'
DELETE FROM LEARNTIME WHERE idTutor = 100001

--CHANGE PASSWORD
UPDATE TUTOR SET password = 'abc' WHERE idTutor = 100001


--CHANGE IMAGE
UPDATE TUTOR SET pic = (SELECT  BulkColumn FROM OPENROWSET(BULK N'D:\DACNPM\image\unnamed.jpg', SINGLE_BLOB) AS img) WHERE idTutor = '100001'
UPDATE TUTOR SET phone = '0123456789', address = N'Liên Chiểu', email = 'email69@gmail.com', identityNumber = '191967851', birth = '1982', gender = N'Nam', status = 1, title = N'Sinh viên', workPlace = N'Đại học bôn ba', description = N'Hê lô' WHERE idTutor = 100001

