--1

select  b.owner_name,  len(b.owner_name) As name_length 
from building b order by  b.owner_name asc

--2

select b.owner_name , b.contact_number from building b where len(owner_name) = (

select min(len(owner_name)) from building )

--3

select building.owner_name ,
CONCAT(building.contact_number,'-',building.email_address) as contact_details
from building order by owner_name desc

--4
select SUBSTRING(meter.meter_number,1,3) as meter_code from meter

--5

select LEFT(building.owner_name , 3) as name_code , building.contact_number from building

--6
select * from building_type
select building_type._name from building_type  where building_type._name like '%t'

--7 

select * from building where owner_name like '%ig%'

