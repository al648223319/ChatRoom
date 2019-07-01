--_________（__index  和 __newIndex）__________________________________________________


--元方法(查询)
Parent = {}
Parent.with = 10

function setDefault(t,d)
local mt = {__index = function() return d  end}
setmetatable(t,mt)
end
print(Parent.with,Parent.high)
setDefault(Parent,10)
print(Parent.with,Parent.high)
--10,nil
--10,10

--当一个table的指定元表后，去查询table中某一个key所对应的值时，table中没有则去元表中查找 ，如果元宝中含有__index，则通过__index 提供值，否则访问结果为nil
--1.当__index指定为函数时，所有查询的值都是方法返回的值
--2.当__index指定为表时，lua就以相同的方式来重新访问元表

Rect  = {}
Rect.w = 10

Area = {}
Area.h = 30
setmetatable(Rect,Area)
Area.__index ={h= 50}
print(Rect.w,Rect.h)
--10,50

--setmetatable方法设置一个表为另一个表的元表（备用表）
--—元表中__index（元方法）为元表提供搜索方式和查询结果


--__newindex（更新）

--__newindex 指定的是函数的话 直接就调用函数
--指定是table的话 如果没有查询的值 就clone到元表中
family = {}
--family.f = "qy"
person = {}
house= {}

setmetatable(family,person)
person.__newindex =house
family.f = "oy"

for k, v in pairs(family) do
	print( "f  " .. v)
end

for k, v in pairs(house) do
	print(k,v)
end
family.m = "zz"

for k, v in pairs(house) do
	print(k,v)
end


--只读表（元表的元方法指向自己，__newindex指向一个方法 打印只读日志

function readOnly(t)
	local proxy = {}
	local mt = {
		__index = t,
		__newindex = function(t,k,v)error("table is readonly")end
		
	}
	setmetatable(proxy,mt)
	return proxy
end

days = readOnly({"*1","*2","*3"})

print(days[1])
--days[2] = "*4"  --报错（只读）
