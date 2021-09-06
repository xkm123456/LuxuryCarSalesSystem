use CarSaleSyetem
insert Bumenbiao
select '管理部' union
select '销售部' union
select '后勤部' 
select * from bumenbiao

insert Glyuanbiao
select 1,'管理部','男','123456' union
select 2,'销售部','女','666666' union
select 3,'后勤部','男','888888' union
select 3,'后勤部','女','654321'
select * from Glyuanbiao

insert Ygbiao
select 3,'张三','男','后勤部长','湖南娄底','18564789981','123456' union
select 1,'李四','女','管理部长','湖南长沙','19613316981','666' union
select 2,'王五','女','销售部长','上海','13646456846','333' union
select 2,'赵六','女','销售人员','浙江杭州','17815165478','987654321' union
select 3,'龙七','男','后勤人员','广东深圳','12896478531','147258369'
select * from ygbiao

insert Gukebiao
select '张三','北京',''