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
select '20201033','202011','���۲�','Ů','123456' union
select '20201034','202012','���ڲ�','��','654321' 
select s.shangPingBianhao from shangPingInfo s,kuCunTable k where s.shangPingBianhao = k.shangPingBianhao and s.shangPingName = '��������'
select * from shangPingInfo where Shangpingname='����'
select top 1 KuCunbianhao from kuCunTable order by KuCunbianhao desc
select top 1 dingHuoDanhao from dingHuoTable order by dingHuoDanhao desc

select * from xiaoShouTable
delete from xiaoShouTable
select * from gysTable
update kuCunTable set kuCunshuliang=2 where shangPingBianhao='0012'
insert dingHuoTable values('20201032','0002','2020-9-1',1,'0014','С�ģ���λ���','�ֽ�')
select kuCunbianhao �����,s.shangPingName ��Ʒ����,kuCunshuliang ������� from kuCunTable k,shangPingInfo s
where k.shangPingBianhao=s.shangPingBianhao

select xiaoShouBianhao ���۱��,s.shangPingBianhao ��Ʒ���,s.shangPingName ��Ʒ����,x.xiaoShouPrice ���ۼ۸�,xiaoShouShuliang ��������,xiaoShouDate ��������,fuKuanStyle ���ʽ from xiaoShouTable x,shangPingInfo s
where x.shangPingBianhao=s.shangPingBianhao 

select kuCunbianhao �����,s.shangPingName ��Ʒ���,kuCunshuliang ������� from kuCunTable k,shangPingInfo s
where s.shangPingBianhao=k.shangPingBianhao

insert kuCunTable values('20201013','0014',1)
select dingHuoDanhao ��������,g.gysName ��Ӧ������,dingHuoDate �ɹ�����,k.kuCunshuliang �ɹ�����,s.shangPingName ��Ʒ����,beiZhu ��ע,fuKuanStyle ���ʽ from dingHuoTable d,gysTable g,shangPingInfo s,kuCunTable k
where d.gysBianhao=g.gysBianhao and d.shangPingBianhao=s.shangPingBianhao and k.shangPingBianhao=s.shangPingBianhao

update kuCunTable set kuCunshuliang+=1 where shangPingBianhao=
(select s.shangPingBianhao from shangPingInfo s,kuCunTable k
where s.shangPingBianhao=k.shangPingBianhao and s.shangPingName='��ʱ��')

select kuCunshuliang from kuCunTable  where shangpingbianhao=(select shangPingBianhao from shangPingInfo where shangPingName='��������')