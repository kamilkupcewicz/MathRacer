variableMode1 = input ("Choose mode (1 - Addition, 2 - Substraction, 3 - Division )")
variableMode2 = input ("Choose mode (1 - 2_digits, 2 - 3_digits)")

click("1578329337668.png")

if variableMode1 == "1":
    click("1578329345878.png")
if variableMode1 == "2":
    click("1578329353340.png")
if variableMode1 == "3":
    click("1578329358956.png")

if variableMode2 == "1":
    click("1578329368406.png")
if variableMode2 == "2":
    click("1578329374872.png")

click(Pattern("1578329410740.png").targetOffset(-30,-8))

type("test")

click("1578329429134.png")

click(Pattern("1578329443466.png").targetOffset(-49,-78))
click(Pattern("1578329443466.png").targetOffset(1,68))
click(Pattern("1578329443466.png").targetOffset(52,74))

sleep(60)

click("1578329503196.png")