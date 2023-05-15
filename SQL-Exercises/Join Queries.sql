EXEC sp_rename 'building_type.name','_name'
 
 select * from building_type 



select meter.meter_number , building.owner_name , building.contact_number , building_type._name , electricity_connection_type.connection_name 
from meter join building on  meter.building_id = building.id 
join building_type on building_type.id = building.building_type_id 
join electricity_connection_type on electricity_connection_type.id = building_type.connection_type_id   
order by 
meter.meter_number, 
building.owner_name

select * from meter ;
select meter.meter_number , building.owner_name , building.contact_number , building_type._name 
from meter join building on  meter.building_id = building.id 
join building_type on building_type.id = building.building_type_id 


select * from building ;
select * from building_type;
select * from electricity_connection_type;

--2

select * from meter


update bill set meter_id = null


select * from bill

select * from meter ;

update bill set meter_id =3 where id =1

update bill set meter_id =4 where id =2

update bill set meter_id =1 where id =3

update bill set meter_id =2 where id =4

select * from bill join meter on meter.id = bill.meter_id order by payable_amount;




--4

select * from slab

select * from electricity_connection_type


select electricity_connection_type.connection_name , slab.from_unit , slab.to_unit , slab.value from slab join electricity_connection_type on slab.connection_type_id = electricity_connection_type.id

--3
select * from meter 

select * from building
select meter.meter_number , building.owner_name , building._address , building.contact_number from building join meter on building.id = meter.building_id  order by building.owner_name , meter.meter_number


-- select building.owner_name , building._address ,  from building
 
--5

select building.owner_name , building._address from building

--6

select * from building



select building.owner_name , building._address , meter.meter_number  from building join  meter on building.id = meter.building_id join(select bill.payable_amount from bill where bill.fine_amount = max(bill.fine_amount)) bill on meter.id = bill.meter_id 

select building.owner_name , building._address , meter.meter_number,bill.payable_amount  from building join  meter on building.id = meter.building_id join bill on meter.id = bill.meter_id where bill.fine_amount = (select max(bill.payable_amount) from bill)

--7
select * from bill

update bill set _month = 5 where id = 3 
update bill set _month = 5 where id = 4


select building.owner_name , building._address , meter.meter_number , bill.total_units
from building 
join meter on building.id = meter.building_id 
join bill on meter.id = bill.meter_id 
where bill._month = 4 And bill._year=23

--8

select * from bill
select building.owner_name , building_type._name , meter.meter_number , ISNULL(CONVERT(varchar(13), bill.payment_date), 'Not Paid Yet') AS Payment_status
from building_type 
join building on building_type.id = building.building_type_id
join meter on building.id = meter.building_id 
join bill on meter.id = bill.meter_id
where bill._month = 4 and bill._year= 23 

--9
insert into building_type values(4,'apartment',10)
insert into building_type values (2,'PG',10)

select * from electricity_connection_type
select * from building_type
select electricity_connection_type.connection_name , 
COUNT(building_type.id) AS connection_count 
from electricity_connection_type 
join building_type on electricity_connection_type.id = building_type.connection_type_id 
group by electricity_connection_type.connection_name;

--10

select * from bill ;
select * from building;

insert into bill values(5 , 4 , 6 , 23,'2023-04-06' , 120 , 180.25 , 0 , null , 100.50)
insert into bill values(6 , 2 , 6 , 23,'2023-04-06' , 170 , 230.75 , 0 , null , 225.70)


select meter.meter_number , building.owner_name , building._address from building 
join meter on building.id = meter.building_id
join (select count(bill.fine_amount) 
group by bill.meter_id )bill on meter.id = bill.meter_id 