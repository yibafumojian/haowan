Set WshShell= WScript.Createobject("WScript.Shell")
for i=1 to 200
WScript.Sleep 30

WshShell.SendKeys"^v"

WshShell.SendKeys "%s"
wshShell.SendKeys "{ENTER}"
next
