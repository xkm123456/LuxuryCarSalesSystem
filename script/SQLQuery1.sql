create database CarSaleSyetem on(
name='car',
filename='E:\豪车销售管理系统\数据库\CarSaleSyetem.mdf'
)
log on(
name='car_log',
filename='E:\豪车销售管理系统\数据库\CarSaleSyetem.ldf'
)
use CarSaleSyetem
create table Bumenbiao(
Bumenbianhao int primary key identity(1,1),
Bumenmingcheng nvarchar(50) not null,
)
create table Glyuanbiao(
Glyuanbianhao int primary key identity(1,1),
Bumenbianhao int foreign key references Bumenbiao(Bumenbianhao),
Bumenmingcheng nvarchar(50) not null,
Sex char(4) check(Sex='男' or Sex='女') not null,
Password nvarchar(15) not null
)
create table Ygbiao(
Ygbianhao int primary key identity(1,1),
Bumenbianhao int foreign key references Bumenbiao(Bumenbianhao),
YgName nvarchar(10) not null,
Sex char(4) check(sex='男' or sex='女') not null,
Zhiwu nvarchar(10) not null,
Address nvarchar(50) not null,
Phone nvarchar(30) not null,
YgPassword nvarchar(10) not null,
)
create table Gukebiao(
Kehubianhao int primary key identity(1,1),
KehuName nvarchar(50) not null,
Address nvarchar(50) not null,
Phone nvarchar(30) not null
)
create table Ddanbiao(
Ddanbianhao int primary key identity(1,1),
Kehubianhao int foreign key references Gukebiao(Kehubianhao),
Ygbianhao int foreign key references Ygbiao(Ygbianhao),
Xiaoshouriqi date not null,
Jhdidian nvarchar(20),
Beizhu nvarchar(20),
WanCZT bit check(WanCZT=0 or WanCZT=1),
FuKfangshi nvarchar(50),
)
create table ShouKbiao(
ShouKbianhao int primary key identity(1,1),
Ddanbianhao int foreign key references Ddanbiao(Ddanbianhao),
ShouKriqi datetime not null,
ShouKjinE money not null,
ShouKfangshi nvarchar(50) not null,
BeiZhu  nvarchar(50) not null
)
create table TuiHuobiao(
TuiHuobianhao int primary key identity(1,1),
Ddanbianhao int foreign key references Ddanbiao(Ddanbianhao),
TuiHuoriqi datetime not null,
LuRuriqi datetime,
ShenHeriqi datetime
)
create table qcleixingbiao(
Qichebianhao int primary key identity(1,1),
QicheLeixing nvarchar(15) not null,
)
create table GYshangbiao(
GYshangbianhao int primary key identity(1,1),
GYshangMC nvarchar(50) not null,
GYshangDiZhi nvarchar(50) not null,
Phone nvarchar(30) not null,
Email varchar(50) not null
)
create table Baojingbiao(
Baojingbianhao int primary key identity(1,1),
Baojingshijian datetime,
BeiZhu nvarchar(50),
CunChuShuLiang int,
ShiFouJieJue bit check(ShiFouJieJue=0 or ShiFouJieJue=1)
)
create table QiChexinxibiao(
Shangpingbianhao int primary key identity(1,1),
QiChebianhao int foreign key references qcleixingbiao(Qichebianhao),
RuKuShiJian datetime not null,
RuKujihuajiage money not null,
Chukujiage money not null,
JIngjieZuiXiaoKuCun int not null,
JIngjieZuiDaKuCun int not null,
YuanShiKuCun int not null
)
create table CangKuxinxibiao(
CangKubianhao int primary key identity(1,1),
CangKumingcheng nvarchar(50) not null
)
create table KuCunbiao(
KuCunbianhao int primary key identity(1,1),
Shangpingbianhao int foreign key references QiChexinxibiao(Shangpingbianhao),
CangKubianhao int foreign key references CangKuxinxibiao(CangKubianhao),
KuCunShuLiang int not null
)
create table DingHuobiao(
DingHuobianhao int primary key identity(1,1),
GYshangbianhao int foreign key references GYshangbiao(GYshangbianhao),
Shangpingbianhao int foreign key references QiChexinxibiao(Shangpingbianhao),
DingHuoShuLiang int not null,
FuFeiFangShi nvarchar(50) not null,
BeiZhu nvarchar(50),
TuiDingZhuangTai bit not null
)
create table FuKuangbiao(
FuKuangdanhao int primary key identity(1,1),
DingHuobianhao int foreign key references DingHuobiao(DingHuobianhao),
FuKuangRiqi datetime not null,
Fukuangfangshi nvarchar(50) not null,
FukuangJinE money not null,
BeiZhu nvarchar not null,
TuiHuoorCaiGou nvarchar(50) not null,
)


