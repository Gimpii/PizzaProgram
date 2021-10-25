 Program RECORD_TEST (output);
{ 21/9/21 Nev Goodyer - styled from link below. Run in Pascal XE }
{ http://xoomer.virgilio.it/gciabu/engl/pascal/pas054.htm }
Uses crt;
Type
  STUDENT = Record
    studID, day, year : Integer ;
    firstName, lastName, DOB: String ;
    gender: Char ;
    avMk : Real ;
  End;
Var
  students : Array [1..10] Of student; { make space for 10 records in array}
  i : Integer;
Begin
  students[1].studID := 1;
  students[1].firstName := 'Johnny';
  students[1].lastName := 'Depp';
  students[1].DOB := '9/6/63';
  students[1].gender := 'm';
  students[1].avMk := 78.2;
  students[2].studID := 2;
  students[2].firstName := 'Jennifer';
  students[2].lastName := 'Lawrence';
  students[2].DOB := '15/8/90';
  students[2].gender := 'f';
  students[2].avMk := 88.2;
  students[3].studID := 3;
  students[3].firstName := 'George';
  students[3].lastName := 'Clooney';
  students[3].DOB := '6/5/61';
  students[3].gender := 'm';
  students[3].avMk := 68.2;
  students[4].studID := 4;
  students[4].firstName := 'Scarlett';
  students[4].lastName := 'Johansson';
  students[4].DOB := '22/11/84';
  students[4].gender := 'f';
  students[4].avMk := 72.2;
  Writeln('students in the default load are: ');
  For i := 1 To 10 Do
    Begin
      Write('Student ', i, ' is ');
      Writeln(students[i].studID,' - ',students[i].firstName,
              ' - ',students[i].lastName,' - ',students[i].DOB
              ,' - ',students[i].gender,' - ',students[i].avMk)
    End
End.
