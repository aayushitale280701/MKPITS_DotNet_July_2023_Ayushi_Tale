CREATE TABLE person_skills (
                             id INT IDENTITY PRIMARY KEY,
                             person_id int,
                             skill_id int,
                             updated_at DATETIME,
                             UNIQUE (person_id, skill_id)
                             );

insert into person_skills values(111,10,'2021-12-12')
insert into person_skills values(112,12,'2021-12-12')
insert into person_skills values(113,13,'2021-12-12')
insert into person_skills values(114,11,'2021-12-12')

select * from person_skills