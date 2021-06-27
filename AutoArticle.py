from datetime import datetime
import JianshuResearchTools as jrt
from JianshuResearchTools.main import GetArticlePublishTime
import requests
import json
import lxml

import os

#定义常量
Path = os.getcwd()
jianshu_request_header = {"User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.90 Safari/537.36 Edg/89.0.774.57",
                          "X-INFINITESCROLL": "true",
                          "X-Requested-With": "XMLHttpRequest"}

#定义未提供的函数

def GetArticleTotalFPCount(article_url: str) -> int:

    jrt.AssertArticleURL(article_url)
    request_url = article_url.replace("https://www.jianshu.com/", "https://www.jianshu.com/asimov/")
    source = requests.get(request_url, headers=jianshu_request_header).content
    json_obj = json.loads(source)
    result = json_obj["total_fp_amount"] / 1000
    return result

def GetArticleMostValuableCommentsCount(article_url: str) -> int:
    request_url = article_url.replace("https://www.jianshu.com/", "https://www.jianshu.com/asimov/")
    source = requests.get(request_url, headers=jianshu_request_header).content
    json_obj = json.loads(source)
    result = json_obj["featured_comments_count"]
    return result

def GetArticleUpdateTime(article_url: str) -> datetime:
    request_url = article_url.replace("https://www.jianshu.com/", "https://www.jianshu.com/asimov/")
    source = requests.get(request_url, headers=jianshu_request_header).content
    json_obj = json.loads(source)
    result = datetime.fromtimestamp(json_obj["last_updated_at"])
    return result

def GetArticleDescription(article_url: str) -> str:
    request_url = article_url.replace("https://www.jianshu.com/", "https://www.jianshu.com/asimov/")
    source = requests.get(request_url, headers=jianshu_request_header).content
    json_obj = json.loads(source)
    result = json_obj["description"]
    return result

#打开读取网址通道
address_file = open(Path + "\\ArticleAddress.txt")
article_address = address_file.read()
address_file.close()

#打开写入通道
article_info_file = open(Path + "\\Article.txt","w",encoding="utf-8")

#info-1 文章标题
article_title = jrt.GetArticleTitle(article_address)
article_info_file.write(article_title)
article_info_file.write(";")

#info-2 文章点赞量
article_likes = jrt.GetArticleLikeCount(article_address)
article_info_file.write(str(article_likes))
article_info_file.write(";")

#info-3 文章获钻量
article_ifp = GetArticleTotalFPCount(article_address)
article_info_file.write(str(article_ifp))
article_info_file.write(";")

#info-4 文章评论量
article_says = jrt.GetArticleCommentCount(article_address)
article_info_file.write(str(article_says))
article_info_file.write(";")

#info-5 文章精选评论
article_value_says = GetArticleMostValuableCommentsCount(article_address)
article_info_file.write(str(article_value_says))
article_info_file.write(";")

#info-6 文章发布时间
article_time = jrt.GetArticlePublishTime(article_address)
article_info_file.write(str(article_time))
article_info_file.write(";")

#info-7 文章最近更新时间
article_new_time = GetArticleUpdateTime(article_address)
article_info_file.write(str(article_new_time))
article_info_file.write(";")

#info-8 文章是否收费
article_payable = jrt.GetArticlePaidStatus(article_address)
if (article_payable):
    article_info_file.write("是")
else:
    article_info_file.write("否")
article_info_file.write(";")

#info-9 文章是否可转载
article_reprintable = jrt.GetArticleReprintStatus(article_address)
if (article_reprintable):
    article_info_file.write("是")
else:
    article_info_file.write("否")
article_info_file.write(";")

#info-10 文章是否可评论
article_sayable = jrt.GetArticleCommentableStatus(article_address)
if (article_sayable):
    article_info_file.write("是")
else:
    article_info_file.write("否")
article_info_file.write(";")

#info-11 纯文本文章内容
artical_text = jrt.GetArticleText(article_address)
article_info_file.write(artical_text)
article_info_file.write(";")