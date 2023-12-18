Create Table PrizeWinnerP (YEARS INT,
                             SUBJECTS  VARCHAR(100),                 
                             WINNER    VARCHAR(100),                                    
                             COUNTRY   VARCHAR(100),
                             CATEGORY  VARCHAR(100)
							 )

insert into PrizeWinnerP values (1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into PrizeWinnerP values (1970,'Physics','Louis Neel','France','Scientist')
insert into PrizeWinnerP values (1970,'Chemistry','Luis Federico Leloir','France','Scientist')
insert into PrizeWinnerP values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into PrizeWinnerP values (1970,'Physiology','Bernard Katz','Germany','Scientist')
insert into PrizeWinnerP values (1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into PrizeWinnerP values (1970,'Economics','Paul Samuelson','USA','Scientist')

SELECT YEARS,SUBJECTS,WINNER,COUNTRY,CATEGORY FROM PrizeWinnerP WHERE  SUBJECTS LIKE 'P%'

--FIRST AND LAST COUNT
SELECT YEARS,SUBJECTS,WINNER,COUNTRY,CATEGORY FROM PrizeWinnerP WHERE  SUBJECTS LIKE 'P%S'

--LAST WORD COUNT
SELECT YEARS,SUBJECTS,WINNER,COUNTRY,CATEGORY FROM PrizeWinnerP WHERE SUBJECTS LIKE '%LOGY%'
