-----------------week table with collection---------------------
--1.normal
local nTab = {}
k = {}
nTab[k] = 3
k = {}
nTab[k] = 4
collectgarbage()
for k,v in pairs(nTab) do
	print(v)
end
--输出 3,4 （）

--2.week table（table中的弱应用类型是通过__mode字段来决定的，这个字段的值应该为一个字符串，“k”代表key是弱引用，“v”代表value是弱引用）
local wTab = {}
local sTab = {__mode = "k"}
setmetatable(wTab,sTab) --现在wTab 的key是弱引用

k = {} --创建第一个key
wTab[k] = 3
k = {} --创建第二个key
wTab[k] = 4

collectgarbage() --强制回收一次垃圾收集
for k,v in pairs(wTab) do
	print(v)
end
--输出 4 （当强制回收时，由于第一个key没有再被引用，所以被回收了。相对应的值和条目也被删除，第二个key因为仍被引用 因此没有被回收）
--ps：1.lua只会回收弱引用table中的对象，如果第一个key为一个数字或者字符串，当收集器工作时，是不会被回收的
--	2.将有些对象放在一个数组中的时候，它是无法被回收的（因为即使没有其它地方引用，但数组还在引用）
--3.环形数据结构，无须做出任何特殊的处理，也会像其它数据一样被正常回收


--模式匹配（关键字：find match gsub gmatch）
--string.find()
local str = "hello world"
local i,j =  string.find(str,"hello") 
print(i,j)
--输出1 5 （返回起始值和终值）
string.find(str,"or",5)
--第三个参数值用来做下一次查找的起始
--例如
local str = "www/baidu/com"
local i = 0
while true do 
	i = string.find(str,"/",i+1)
	if i == nil then
		break
	else
		print(i)
	end
end
--输出 4 10



--string.match()
--返回与目标字符串匹配那段字串
local str = "hello world"
local cStr = string.match(str,"hello")
print(cStr) -- "hello"
--正常运用
local data = "This is 2019/07/04"
print(string.match(data,"%d+/%d+/%d+")) -- "2019/07/04"


--string.gsub()
--模式替换
local name = "my name ouyanglinxin"
local newName = string.gsub(name,"linxin","zhi")
print(newName) --"my name ouyangzhi"

--ps:可选第四个参数（替换次数）

--string.gmatch()
--返回一个迭代函数
s = "hello world from lua"
for w in string.gmatch(s, "%a+") do
  print(w)
end
-- hellow
--world
--from
--lua

t = {}
s = "from=world, to=Lua"
for k, v in string.gmatch(s, "(%w+)=(%w+)") do
  t[k] = v
end
for k,v in pairs(t) do
print(k,v)
end

---from  world -- to Lua


-------------------模式---------------------------

--   %a     --字母
--   %d     --数字
--   %c     --控制字符
--   %w     --字母数字
--   %p     --标点符号
--   %l     --小写字母
--   %u     --大写字母
--   %s     --空白字符
--   %z     --内部表示为0的字符
--   %x     --十六进制数字

-- () . % + - * ? [] ^ $
--  +  重复1次或多次
--  *  重复0次或多次
--  ？ 0次或1次
  

