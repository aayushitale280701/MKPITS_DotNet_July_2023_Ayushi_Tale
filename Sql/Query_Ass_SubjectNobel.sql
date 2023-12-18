Create Table SubjectNobel (YEARS INT,
                             SUBJECTS  VARCHAR(100),                 
                             WINNER    VARCHAR(100),                                    
                             COUNTRY   VARCHAR(100),
                             CATEGORY  VARCHAR(100)
							 )

insert into SubjectNobel values (1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into SubjectNobel values (1970,'Physics','Louis Neel','France','Scientist')
insert into SubjectNobel values (1970,'Chemistry','Luis Federico Leloir','France','Scientist')
insert into SubjectNobel values (1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into SubjectNobel values (1970,'Physiology','Bernard Katz','Germany','Scientist')
insert into SubjectNobel values (1970,'Literature','Aleksandr Solzhenitsyn','Russia','Linguist')
insert into SubjectNobel values (1970,'Economics','Paul Samuelson','USA','Scientist')

select YEARS,SUBJECTS,WINNER,COUNTRY,CATEGORY FROM SubjectNobel WHERE  SUBJECTS='Economics' or SUBJECTS='Physiology'
