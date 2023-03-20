from datetime import datetime

import DATA


global now
global current_time
now = datetime.now()
current_time = now.strftime("%H:%M:%S")

    



def resetVal():
    a = ""
    b = ""
    return a, b



def clockIn():
    global start_time
    start_time = ((int)(now.strftime("%H")) * 60) + (int)(now.strftime("%M"))
    return start_time


def clockOut():
    global end_time
    end_time = ((int)(now.strftime("%H")) * 60) + (int)(now.strftime("%M"))
    return end_time

def calculateTimeWorked(start_time, end_time):
    timeWorked = end_time - start_time
    timeWorkedHours = timeWorked / 60
    timeWorkedMinutes = timeWorked % 60
    timeWorkedHoursMinutes = [timeWorkedHours, timeWorkedMinutes]

    return timeWorkedHoursMinutes

def resetVal():
    start_time = 0
    end_time = 0