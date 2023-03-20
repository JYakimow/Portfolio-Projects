import json
import sys
import os



def findByID(id):
    x = 0
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        while x < len(data1["users"]):
            if(data1["users"][x]["id"] == id):
                return x
            x += 1

def getClockedStatus(id):
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        info = findByID(id)
        return data1["users"][info]["clockedStatus"]

def getTotalMinutes(id):
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        info = findByID(id)
        return data1["users"][info]["totalMinutes"]

def getPin(id):
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        info = findByID(id)
        return data1["users"][info]["pin"]

def getName(id):
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        info = findByID(id)
        return data1["users"][info]["name"]


def changeClockedStatus(id):
    info = findByID(id)
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        
        if(getClockedStatus(id) == True):
            data1["users"][info]["clockedStatus"] = False
        else:
            data1["users"][info]["clockedStatus"] = True
        f.seek(0)
        json.dump(data1,f)
        f.truncate()
        
def calculateTime(id):
    min = getTotalMinutes(id)
    h = (int)(min / 60)
    min = min % 60
    if min < 10:
        return str(h) + ":0" + str(min)
    else:
        return str(h) + ":" + str(min)
    
def changeHourBreak(id):
    info = findByID(id)
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        
        data1["users"][info]["hourBreak"] -= 1

        f.seek(0)
        json.dump(data1,f)
        f.truncate()
        

def changeSmallBreak(id):
    info = findByID(id)
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        
        data1["users"][info]["smallBreak"] -= 1

        f.seek(0)
        json.dump(data1,f)
        f.truncate()
    
        
def changeMin(id, amount):
    info = findByID(id)
    with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
        data1 = json.load(f)
        
        data1["users"][info]["totalMinutes"] += amount

        f.seek(0)
        json.dump(data1,f)
        f.truncate()
  
def checkCredentials(Id, passcode):
    info = findByID(Id)
    if(info != None):
        with open(os.path.join(os.path.dirname(sys.argv[0]), 'UserInfo.json'), 'r+') as f:
            data1 = json.load(f)
            if data1["users"][info]["pin"] == passcode:
                return 1
            
    return 0
                


def main():
    print(getClockedStatus(100001))
    changeClockedStatus(100001)
    print(getClockedStatus(100001))
    changeMin(100001,5)
    


if __name__ == "__main__":
	main()