from ast import literal_eval
# 21/9/21 Nev Goodyer - sites used are:
# https://realpython.com/python-data-structures/#dict-simple-data-objects
# https://www.w3schools.com/python/python_arrays.asp
# https://www.w3schools.com/python/trypython.asp?filename=demo_class4

class Student:
  def __init__(students, studID, firstName, lastName, DOB, gender, avMk):
    students.studID = studID
    students.firstName = firstName
    students.lastName = lastName
    students.DOB = DOB
    students.gender = gender
    students.avMk = avMk

  def strConcat(index):
    print("Record", index.studID, "-", index.firstName, "-", index.lastName, "-", index.DOB, "-", index.gender, "-", index.avMk)

s1 = Student(1, "Johnny", "Depp","9/6/63","m",78.2)
s2 = Student(2, "Jennifer", "Lawrence","15/8/90","f",88.2)
s3 = Student(3, "George", "Clooney","6/5/61","m",68.2)
s4 = Student(4, "Scarlett", "Johansson","22/11/84","f",72.2)

s1.strConcat()
s2.strConcat()
s3.strConcat()
s4.strConcat()
