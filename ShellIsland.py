import json
from datetime import datetime
import JianshuResearchTools as jrt

import requests
import os

#定义未提供的函数
def UserUrlToUserSlug(user_url: str) -> str:
    #该函数接收用户个人主页 Url，并将其转换成用户 Slug
    return user_url.replace("https://www.jianshu.com/u/", "").replace("/", "")

def GetBeikeIslandTotalTradeRankData(page: int =1) -> list:
    data = {
        "ranktype": 3, 
        "pageIndex": page
    }
    source = requests.post("https://www.beikeisland.com/api/Trade/getTradeRankList", 
                            headers=BeikeIsland_request_header, json=data).content
    json_obj = json.loads(source)
    result = []
    for item in json_obj["data"]["ranklist"]:
        item_data = {
            "bkuid": item["userid"], 
            "jianshuname": item["jianshuname"], 
            "avatar": item["avatarurl"], 
            "userurl": item["jianshupath"], 
            "uslug": UserUrlToUserSlug(item["jianshupath"]), 
            "total_trade_amount": item["totalamount"], 
            "total_trade_times": item["totaltime"]
        }
        result.append(item_data)
    return result

#定义常量
Path = os.getcwd()
BeikeIsland_request_header = {"Host": "www.beikeisland.com",
                            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36 Edg/89.0.774.57",
                            "Content-Type": "application/json",
                            "Version": "v2.0"}

#打开写入通道
shellisland_info_file = open(Path + "\\ShellValue.txt","w",encoding="utf-8")     

#info-1 贝壳小岛总交易量
tradeamount = jrt.GetBeiKeIslandTotalTradeAmount()
shellisland_info_file.write(str(tradeamount))
shellisland_info_file.write(";")

#info-2 贝壳小岛总交易排行榜用户
tradetotal = GetBeikeIslandTotalTradeRankData()
#一个狰狞可怖的嵌套
dictionary = tradetotal[0] #拿到嵌套的字典
all_user = []


print(str(tradeamount[0]))