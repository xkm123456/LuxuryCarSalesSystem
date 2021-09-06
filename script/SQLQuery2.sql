select * from QiChexinxibiao
insert Glyuanbiao
select '1','管理部','男','888888' union
select '2','销售部','女','123' union
select '3','后勤部','男','666' 
select * from Ygbiao
insert Bumenbiao
select 1,'管理部' union
select 2,'销售部' union
select 3,'后勤部' 
insert Ygbiao 
select '管理部','张三','男',10000.00,'湖南长沙','16594658967','666666','管理部长' union
select '后勤部','李四','男',6000.00,'湖北武汉','15464612312','123456','后勤部长' union
select '后勤部','王五','男',4000.00,'上海','19853456011','33333','后勤人员' union
select '销售部','赵六','女',8000.00,'北京','12577693721','123','销售部长' union
select '销售部','蒋二','女',7000.00,'广东深圳','17961261639','888888','销售人员' 
delete from Ygbiao
select * from Ygbiao
select * from DingHuobiao
select * from GYshangbiao
select distinct Dinghuodate,FuFeiFangShi,TuiDingZhuangTai from DingHuobiao
insert DingHuobiao values('')
insert GYshangbiao values(2,'兰博基尼','湖北武汉','16598764513','535432241@163.com')
insert GYshangbiao values(3,'德国大众','上海','19465867512','6354944@qq.com')
insert GYshangbiao values(4,'劳斯莱斯','北京','13698754612','6413155@sina.com')
delete from DingHuobiao
select * from DingHuobiao
insert DingHuobiao values(2,1,10,'现金','别刮坏了','是','2020年9月12日 星期六')
insert DingHuobiao values(3,2,5,'刷卡','别碰坏了','是','2020年9月13日 星期日')
insert DingHuobiao values(3,1,6,'刷卡','别碰坏了','否','2020年9月14日 星期一')
select Dinghuodate,FuFeiFangShi,TuiDingZhuangTai from DingHuobiao