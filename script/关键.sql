use CarSaleSyetem
select distinct WanCZT,FuKfangshi from Ddanbiao
select Shangpingbianhao 商品编号,QiChebianhao 汽车编号,Shangpingmingcheng 商品名称,RuKujihuajiage 入库价格,Chukujiage 出库价格,JIngjieZuiXiaoKuCun 最小库存,JIngjieZuiDaKuCun 最大库存,YuanShiKuCun 原始库存,color 颜色,shangpingjs 商品介绍 from QiChexinxibiao
select * from DingHuobiao
select * from Ddanbiao where 2<=Ddanbianhao and Ddanbianhao<=4


select * from Ddanbiao
SELECT *
FROM Ddanbiao
ORDER BY Ddanbianhao
OFFSET 0 ROWS
FETCH NEXT 3 ROWS ONLY;