use car
select * from shangPingInfo
select * from dingHuoTable
select * from kuCunTable
select * from xiaoShouTable
select * from gysTable
select * from shangPingInfo
select shangpingname,gysbianhao,jinhuoPrice,xiaoshouprice from shangPingInfo
select * from Ygbiao
select * from Glyuanbiao
select * from Bumenbiao
insert Glyuanbiao 
select '20201033','202011','销售部','女','123456' union
select '20201034','202012','后勤部','男','654321' 
select s.shangPingBianhao from shangPingInfo s,kuCunTable k where s.shangPingBianhao = k.shangPingBianhao and s.shangPingName = '兰博基尼'
select * from shangPingInfo where Shangpingname='宾利'
select top 1 KuCunbianhao from kuCunTable order by KuCunbianhao desc
select top 1 dingHuoDanhao from dingHuoTable order by dingHuoDanhao desc

select * from xiaoShouTable
delete from xiaoShouTable
select * from gysTable
update kuCunTable set kuCunshuliang=2 where shangPingBianhao='0012'
insert dingHuoTable values('20201032','0002','2020-9-1',1,'0014','小心，别刮坏了','现金')
select kuCunbianhao 库存编号,s.shangPingName 商品名称,kuCunshuliang 库存数量 from kuCunTable k,shangPingInfo s
where k.shangPingBianhao=s.shangPingBianhao

select xiaoShouBianhao 销售编号,s.shangPingBianhao 商品编号,s.shangPingName 商品名称,x.xiaoShouPrice 销售价格,xiaoShouShuliang 销售数量,xiaoShouDate 销售日期,fuKuanStyle 付款方式 from xiaoShouTable x,shangPingInfo s
where x.shangPingBianhao=s.shangPingBianhao 

select kuCunbianhao 库存编号,s.shangPingName 商品编号,kuCunshuliang 库存数量 from kuCunTable k,shangPingInfo s
where s.shangPingBianhao=k.shangPingBianhao

insert kuCunTable values('20201013','0014',1)
select dingHuoDanhao 订货单号,g.gysName 供应商名称,dingHuoDate 采购日期,k.kuCunshuliang 采购数量,s.shangPingName 商品名称,beiZhu 备注,fuKuanStyle 付款方式 from dingHuoTable d,gysTable g,shangPingInfo s,kuCunTable k
where d.gysBianhao=g.gysBianhao and d.shangPingBianhao=s.shangPingBianhao and k.shangPingBianhao=s.shangPingBianhao

update kuCunTable set kuCunshuliang+=1 where shangPingBianhao=
(select s.shangPingBianhao from shangPingInfo s,kuCunTable k
where s.shangPingBianhao=k.shangPingBianhao and s.shangPingName='保时捷')

select kuCunshuliang from kuCunTable  where shangpingbianhao=(select shangPingBianhao from shangPingInfo where shangPingName='兰博基尼')