from ast import Lambda
from pickle import GLOBAL
from tkinter import *

import debug
import DATA
from tkinter import ttk

import function_01
import PythonApplication1 as P1

frame1 = True
#frame1 
def openFrame1():
   
    top = Tk()
    top.resizable(width=False, height=False)
    if frame1 == True:
        
        top.geometry("400x250")
        L1 = Label(top, text="ID:")
        L1.pack()
        E1 = Text(top, width=20,height=1)

        E1.insert(END, "Enter ID")
        E1.pack()


        top.geometry("700x350")
        L2 = Label(top, text="Passcode:")
        L2.pack()
        E2 = Text(top, width=20,height=1)

        E2.insert(END, "Enter Passcode")
        E2.pack()

        L3 = Label(top )
        L3.pack()


        def getLogin():
            global frame1
            if(DATA.checkCredentials((E1.get(1.0, "end-1c")) ,(E2.get(1.0, "end-1c")) ) == 1):
                
                print(1)
                P1.currentUserId = (E1.get(1.0, "end-1c"))
                frame1 = False
                top.destroy()
                openFrame1() 
            else: 
                print(0)
                frame1 = True
        

        B = ttk.Button(top, text ="Confirm", command=lambda: getLogin() )
        B.pack( ipadx=10, ipady = 5)
        B.place(relx=.44, rely=.3, anchor="center")

        QuitButton = ttk.Button(top, text ="Quit", command=top.destroy)
        QuitButton.pack( ipadx=10, ipady = 10)
        QuitButton.place(relx=.56, rely=.3, anchor="center")

        

    else:
    
        top.geometry("400x250") 
        top.title("Frame 2")
   
        # the label for username
        #frame1_user_id = Label(frame1, text = "Employee ID").place(x = 35, y = 60) 
   
        # the label for user_password 
        #frame1_user_pin = Label(frame1, text = "Pin").place(x = 80, y = 100) 
   
        #frame1_user_name_input_area = Entry(frame1, width = 30).place(x = 110, y = 60) 
        #frame1_user_password_entry_area = Entry(frame1, width = 30).place(x = 110, y = 100) 

        frame2_label = Label(top, text = "Hello " + DATA.getName(P1.currentUserId))
        frame2_label.pack()
        frame2_label.place(relx=.5,rely=.1,anchor="center")

        frame2_hours = Label(top,text = "Your total time worked is: " + str(DATA.calculateTime(P1.currentUserId)))
        frame2_hours.pack()
        frame2_hours.place(relx=.5,rely=.175,anchor="center")

        frame2_clock_in_button = ttk.Button(top, text = "\nClock In\n")
        frame2_clock_in_button.pack( ipadx=10, ipady = 10)
        frame2_clock_in_button.place(relx=.4, rely=.375, anchor="center")
        
        frame2_clock_out_button = ttk.Button(top, text = "\nClock Out\n")
        frame2_clock_out_button.pack( ipadx=10, ipady = 50)
        frame2_clock_out_button.place(relx=.6, rely=.375, anchor="center")


        frame2_30min_break_button = ttk.Button(top, text = "\n30 Minute\n    Break\n")
        frame2_30min_break_button.pack(ipadx=0, ipady = 50)
        frame2_30min_break_button.place(relx=.6, rely=.65, anchor="center")

        frame2_15min_break_button = ttk.Button(top, text = "\n15 Minute\n    Break\n")
        frame2_15min_break_button.pack(ipadx=0, ipady = 50)
        frame2_15min_break_button.place(relx=.4, rely=.65, anchor="center")
        
        def changeScreen():
            global frame1
            frame1 = True
            top.destroy()
            openFrame1() 

        QuitButton = ttk.Button(top, text ="Log Out", command=lambda: changeScreen())
        QuitButton.pack( ipadx=10, ipady = 10)
        QuitButton.place(relx=.5, rely=.875, anchor="center")

    top.mainloop()