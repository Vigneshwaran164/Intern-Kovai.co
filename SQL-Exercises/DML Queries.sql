create database Elecricity_Bill

EXEC sp_renamedb 'Elecricity_Bill', 'Electricity_Bill' 

use Electricity_Bill

create table electricity_connection_type (id int, connection_name varchar(20));

select * from electricity_connection_type

drop table electricity_connection_type

create table electricity_connection_type (id int PRIMARY KEY , connection_name varchar(20) NOT NULL)

create table slab(id int PRIMARY KEY, connection_type_id int FOREIGN KEY (connection_type_id) REFERENCES electricity_connection_type(id) NOT NULL , from_unit int NOT NULL , to_unit int NOT NULL , rate int , value DOUBLE PRECISION NOT NULL)

create table building_type(id int , name varchar(100) not null , connection_type_id int foreign key (connection_type_id) references electricity_connection_type(id))

alter table building_type alter column id int not null;

alter table building_type add constraint id primary key(id);

create table building(id int , owner_name varchar(100) not null , _address varchar(100) not null, building_type_id int foreign key (building_type_id) references building_type(id) )

select * from building

sp_rename 'building.owner_name','building_owner_name','COLUMN' 

alter table building alter column _address varchar(255) 

alter table electricity_connection_type add constraint check_connection_name check(connection_name in ('commercial','home'))

sp_rename 'building','building_details'

drop table slab ;

drop table building_details


--second assignment

insert into electricity_connection_type values(10,'home')
insert into electricity_connection_type values(45,'commercial')


select * from electricity_connection_type


create table slab(id int PRIMARY KEY, connection_type_id int FOREIGN KEY (connection_type_id) REFERENCES electricity_connection_type(id) NOT NULL , from_unit int NOT NULL , to_unit int NOT NULL , rate int , value DOUBLE PRECISION NOT NULL)

alter table slab drop column rate



insert into slab values(7,10,100,500,70)
insert into slab values(55,45,100,400,34.5)
insert into slab values(18,10,100,450,48.5)
insert into slab values(3,45,100,300,55

select * from slab


create table building(id int, owner_name varchar(100) not null , _address varchar(100) not null, building_type_id int foreign key (building_type_id) references building_type(id) , contact_number varchar(100) not null , email_address varchar(100))

alter table building alter column id int not null
alter table building add constraint building_id primary key(id)



select * from electricity_connection_type

insert into building_type values(1,'Shopping Mall',45)
insert into building_type values(2,'Apartment',10)
insert into building_type values(3,'Theatre',45)
insert into building_type values(4,'PG',10)
insert into building_type values(6,'Shopping Mall',45)

delete from building_type where id=6
select * from building_type

select * from slab ;

update slab set from_unit = 1 

update building_type set name = 'Mall' where name = 'Shopping Mall'

truncate table slab;

delete from building_type where connection_type_id = 10 

select * from building_type

select * from building_type order by name asc



insert into building values (1,'BrookeFields','pollachi',1,8879565656,'abc123@gmail.com')
insert into building values (2,'Fun Mall','coimbatore',1,8879563556,'def123@gmail.com')
insert into building values (3,'Broadway','coimbatore',1,9187956556,'ghi123@gmail.com')
insert into building values (4,'Thangam Cinemas','pollachi',3,8779565656,'jkl123@gmail.com')

update building set owner_name = 'vignesh' where owner_name = 'BrookeFields'
update building set owner_name = 'Rohit' where owner_name = 'Fun Mall'
update building set owner_name = 'Sachin' where owner_name = 'Broadway'
update building set owner_name = 'Dhoni' where owner_name = 'Thangam Cinemas'



insert into building values(5,'vignesh','meenakshipuram',3 , 7584654854,'mno@gmail.com')
insert into building values (6,'adam','coimbatore', 5 ,7487324578 , null)






select * from building order by owner_name asc ;

create table meter(id int primary key , meter_number varchar(100) not null ,building_id int foreign key (building_id) references building(id))

create table electricity_reading (id int primary key , meter_id int foreign key (meter_id) references meter(id))
drop table electricity_reading


select * from building_type

select * from building



select * from meter

insert into meter values(1,'10AB11',3)
insert into meter values(2,'10AB12',1)
insert into meter values(3,'10AB13',2)
insert into meter values(4,'10AB14',4)



create table electricity_reading (id int primary key , meter_id int foreign key (meter_id) references meter(id) , _day Date not null , hour_first_8 int , hour_second_8 int , hour_third_8 int , total_units int not null)

insert into electricity_reading values ( 1 , 1 , '2023-4-30' , 100 , 110 ,200 , 410 )
insert into electricity_reading values ( 2 , 2 , '2023-4-30' , 200 , 100 ,150 , 450 )
insert into electricity_reading values ( 3 , 3 , '2023-4-30' , 400 , 200 ,100 , 700 )
insert into electricity_reading values ( 4 , 4 , '2023-4-30' , 100 , 150 , 250 , 500 )


update electricity_reading set hour_first_8 = 100 , hour_second_8 = 110 , hour_third_8 = 200 , total_units = 410 where id =1

update electricity_reading set hour_first_8 = 200 , hour_second_8 = 100 , hour_third_8 = 150 , total_units = 450 where id =2

update electricity_reading set hour_first_8 = 400 , hour_second_8 = 200 , hour_third_8 = 100 , total_units = 700 where id =3

update electricity_reading set hour_first_8 = 100 , hour_second_8 = 150 , hour_third_8 = 250 , total_units = 500 where id =4
select * from electricity_reading


select * from electricity_reading order by total_units desc

select meter_number from meter 

select * from meter 

select * from building

select owner_name , contact_number from building order by owner_name asc

create table bill(id int primary key , meter_id int foreign key(meter_id) references meter(id) , _month int not null , _year int not null , due_date date not null , total_units int ,payable_amount double precision , ispayed tinyint , payment_date date , fine_amount double precision)

alter table bill alter column  total_units int not null
alter table bill alter column payable_amount double precision not null
alter table bill alter column  ispayed tinyint not null 

insert into bill values(1 , 1 , 4 ,23 , '2023-06-05' , 200 , 250.4 , 1 , '2023-05-30' , null )

insert into bill values(2 ,2, 4 ,23 , '2023-06-05' , 250 , 320.50 , 0 , null , 20.00 )


insert into bill values(3 , 3 , 4 ,23 , '2023-06-05' , 180 , 220.00 , 1 , '2023-05-30' , null )
insert into bill values(4 , 4 , 4 ,23 , '2023-06-05' , 300 , 400.50 , 0 , null , 102.86 )


select * from bill

select total_units , payable_amount , fine_amount from bill order by total_units desc


insert into slab values(7,10,100,500,70)
insert into slab values(55,45,100,400,34.5)
insert into slab values(18,10,100,450,48.5)
insert into slab values(3,45,100,300,55)

select * from slab order by from_unit asc

select * from building where owner_name='vignesh'

select * from bill where total_units > 200 

select * from bill where due_date = '2023-06-05'

select owner_name , _address , contact_number from building where email_address is null 

select * from building where owner_name like 'v%'

select * from building where building_type_id = 3 order by owner_name asc

select * from electricity_reading where total_units between 400 and 600 order by total_units desc

select meter_id , total_units from electricity_reading where hour_second_8 < hour_third_8 order by total_units desc

select * from electricity_reading


					



