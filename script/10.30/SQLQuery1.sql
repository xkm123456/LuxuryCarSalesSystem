select * from dingHuoTable
select * from shangPingInfo
select * from kuCunTable
select * from gysTable
select distinct shangpingbianhao,shangpingname, gysbianhao from shangPingInfo
select dingHuoDanhao �������,g.gysName ��Ӧ������,d.dingHuoDate ��������,dingDanShuliang ��������,s.shangPingName ��Ʒ����,beiZhu ��ע,fuKuanStyle ���ʽ from dingHuoTable d,shangPingInfo s,gysTable g
where d.shangPingBianhao=s.shangPingBianhao and s.gysBianhao=g.gysBianhao

select s.shangPingName ��Ʒ����,k.kuCunshuliang �������,s.xiaoShouPrice �۸�,s.carjieshao �������� from kuCunTable k,shangPingInfo s
where k.shangPingBianhao=s.shangPingBianhao

select shangPingBianhao ��Ʒ���,shangPingName ��Ʒ����,gysBianhao ��Ӧ�̱��,
jinHuoPrice �����۸�,xiaoShouPrice ���ۼ۸�,carjieshao �������� 
from shangPingInfo where shangPingBianhao=''and shangPingName=''