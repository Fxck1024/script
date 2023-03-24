import requests
import re
import os
from threading import Thread
from time import sleep
import time
import json
def Downloads(url,name):
    with open(title+'/'+name, 'wb') as f:
        f.write(requests.get(url=url, headers=headers).content)
    sleep(0.3)
    print(f'下载{name}完成')
if __name__== "__main__" :
    url = input('输入你想下载的网页链接: ')
    headers = {
        'user-agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.5163.147 Safari/537.36',
        'referer': 'https://everia.club/',
        'cookie': 'wschkid=2a3cbd61b10361f8877c592d8aca33308a1caff7.1679658767.1'
    }
    reg = 'https://everia.club/wp-json/wp/v2/posts/\d*'
    r = requests.get(url=url, headers=headers)
    e = re.findall(reg, str(r.headers))[0]
    headers['referer'] = e
    r = requests.get(url=e, headers=headers).text
    d = json.loads(r)
    reg = 'https://.*jpg'
    title = d['title']['rendered']
    i = re.findall(reg, d['content']['rendered'])
    n = [x.split("/")[-1] for x in i]
    if not os.path.exists(title):
        print(f'创建文件夹{title}')
        os.mkdir(title)
    start = time.time()
    theadlist = []
    for u in range(len(n)):
        thread = Thread(target=Downloads,
                        args=(i[u], n[u])
                        )
        thread.start()
        theadlist.append(thread)
    for thread in theadlist:
        thread.join()
    print(f'全部下载完成,共{len(n)}张')
    end = time.time()
    print("总耗时:"+str(int(end-start))+"秒")