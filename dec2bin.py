# Function to convert decimal number 
# to binary using recursion 
def DecimalToBinary(num): 
      
    if num > 1: 
        DecimalToBinary(num // 2) 
    print(num % 2, end = '') 
Check = False
while not Check:
#while pazime==False:
#while paziime!=True:
    try:
        dec_val = int(input("Enter Decimal Value: \n"))
        DecimalToBinary(dec_val) 
        Check = True
    except:
        print("Invalid input :-(")
        print("Please try again :-)")


