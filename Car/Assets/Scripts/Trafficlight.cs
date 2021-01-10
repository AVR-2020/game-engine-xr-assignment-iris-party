function Start()
{
 
Yellow.enabled = false;
 
while(true)
{
Green.enabled = true;
Red.enabled = false;
yield WaitForSeconds(30);
Yellow.enabled = true;
Green.enabled = false;
yield WaitForSeconds(4);
Red.enabled = true;
Yellow.enabled = false;
yield WaitForSeconds (30);
}
}
