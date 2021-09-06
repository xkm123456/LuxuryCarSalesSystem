select * from dingHuoTable
select * from shangPingInfo
select * from kuCunTable
select * from gysTable
select distinct shangpingbianhao,shangpingname, gysbianhao from shangPingInfo
select dingHuoDanhao 订单编号,g.gysName 供应商名称,d.dingHuoDate 订货日期,dingDanShuliang 订单数量,s.shangPingName 商品名称,beiZhu 备注,fuKuanStyle 付款方式 from dingHuoTable d,shangPingInfo s,gysTable g
where d.shangPingBianhao=s.shangPingBianhao and s.gysBianhao=g.gysBianhao

select s.shangPingName 商品名称,k.kuCunshuliang 库存数量,s.xiaoShouPrice 价格,s.carjieshao 汽车介绍 from kuCunTable k,shangPingInfo s
where k.shangPingBianhao=s.shangPingBianhao

select shangPingBianhao 商品编号,shangPingName 商品名称,gysBianhao 供应商编号,
jinHuoPrice 进货价格,xiaoShouPrice 销售价格,carjieshao 汽车介绍 
from shangPingInfo where shangPingBianhao=''and shangPingName=''