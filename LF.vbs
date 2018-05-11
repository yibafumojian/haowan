Set WshShell= WScript.Createobject("WScript.Shell")
for i=1 to 20
WScript.Sleep 300

WshShell.SendKeys"^v"
WshShell.SendKeys i
WshShell.SendKeys "%s"
next
