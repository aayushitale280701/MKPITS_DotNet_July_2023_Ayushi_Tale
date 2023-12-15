Create table Nobel_Prize(YEARS int, 
                                SUBJECTS varchar(20),
								WINNER varchar(50),
								COUNTRY varchar(20),
								CATEGORY varchar(20))

insert into Nobel_Prize values(1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into Nobel_Prize values(1970,'Physics','Louis Neel','France','Scientist')
insert into Nobel_Prize values(1972,'Chemistry','Luis Federico Leloir','France','Scientist')
insert into Nobel_Prize values(1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into Nobel_Prize values(1973,'Physiology','Bernard Katz','Germany','Scientist')
insert into Nobel_Prize values(1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into Nobel_Prize values(1970,'Economics','Paul Samuelson','USA','Scientist')
Select YEARS,SUBJECTS,WINNER from Nobel_Prize Where YEARS='1970'