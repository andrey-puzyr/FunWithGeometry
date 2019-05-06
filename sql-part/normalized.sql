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
drop table if exists #refs;

select *
into #cat
from (
	select 1 as id, 'A' as label union 
	select 2 as id, 'B' as label union 
	select 3 as id, 'C' as label 
) t

select *
into #prod
from (
	select 1 as id, 'x' as label   union 
	select 2 as id, 'y' as label   union 
	select 3 as id, 'z' as label
) t

select *
into #refs
from (
	select 1 as catId, 1 as prodId union 
	select 1 as catId, 2 as prodId union 
	select 2 as catId, 2 as prodId  
) t

-- calculate
select c.label, p.label
from #refs r
	left  join #cat c on r.catId = c.Id
	left  join #prod p on r.prodId = p.Id
union all
	select c.label, null
	from #cat c
	where id not in (select distinct catId from #refs)
union all
	select null, p.label
	from #prod p
	where id not in (select distinct prodId from #refs)