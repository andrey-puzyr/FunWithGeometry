/*
Expected result:

A    x
A    y
B    y
C    null
null z
*/

-- prepare test data

--create database Sandbox;
drop table if exists #cat;
drop table if exists #prod;

select *
into #cat
from (
	select 1 as id, 'A' as label, 1 as ref  union 
	select 1 as id, 'A' as label, 2 as ref  union 
	select 2 as id, 'B' as label, 2 as ref  union 
	select 3 as id, 'C' as label, null as ref   
) t

select *
into #prod
from (
	select 1 as id, 'x' as label, 1 as ref    union 
	select 2 as id, 'y' as label, 1 as ref    union 
	select 2 as id, 'y' as label, 2 as ref    union 
	select 3 as id, 'z' as label, null as ref    
) t

-- calculate
select c.label, p.label
from #cat c full outer join #prod p on  c.ref = p.id or p.ref = c.id
group by c.label, p.label
