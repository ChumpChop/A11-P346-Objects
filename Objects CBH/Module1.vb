Module Module1
    Sub Main()
        'Create a new sports car object
        Using objCar As New SportsCar
            'Set the horsepower and weight(kg)
            objCar.HorsePower = 240
            objCar.Weight = 1085

            'Display the details of the car
            DisplayCarDetails(objCar)
            DisplaySportsCarDetails(objCar)
        End Using

        'Wait for input from the user
        Console.ReadLine()
    End Sub


    'Sub Main()
    '    'Create a New sports car object
    '    Dim objCar As New SportsCar

    '    ''Modify the number of doors
    '    'objCar.NumberOfDoors = 2

    '    'Set the horsepower And weight(kg)
    '    objCar.HorsePower = 240
    '    objCar.Weight = 1085

    '    'Display the details of the car
    '    DisplayCarDetails(objCar)
    '    DisplaySportsCarDetails(objCar)

    '    'Wait for input from the user
    '    Console.ReadLine()

    '    'Create a New car object
    '    'Dim objCar As New Car

    '    'Display the details of the car
    '    'DisplayCarDetails(objCar)

    '    'Wait for input from the user
    '    Console.ReadLine()

    '    'Accelerate the car to 25mph
    '    objCar.Accelerate(25)

    '    'Report whether Or Not the car Is moving
    '    If objCar.IsMoving = True Then
    '        Console.WriteLine("The car Is moving.")
    '    Else
    '        Console.WriteLine("The car Is stopped.")
    '    End If
    '    'Wait for input from the user
    '    Console.ReadLine()


    '    'Report the number of doors
    '    Console.WriteLine("The number of doors Is:")
    '    Console.WriteLine(objCar.NumberOfDoors)

    '    'Try changing the number of doors to 1000
    '    objCar.NumberOfDoors = 1000

    '    'Report the number of doors
    '    Console.WriteLine("The number of doors Is:")
    '    Console.WriteLine(objCar.NumberOfDoors)

    '    'Now try changing the number of doors to 2
    '    objCar.NumberOfDoors = 2

    '    'Report the number of doors
    '    Console.WriteLine("The number of doors Is:")
    '    Console.WriteLine(objCar.NumberOfDoors)

    '    'Wait for input from the user
    '    Console.ReadLine()

    '    'Set the Color property to Red
    '    objCar.Color = "Red"

    '    'Show what the value of the property Is
    '    Console.WriteLine("My car Is this color:")
    '    Console.WriteLine(objCar.Color)

    '    'Wait for input from the user
    '    Console.ReadLine()

    '    'Report the speed
    '    Console.WriteLine("The car's speed is:")
    '    Console.WriteLine(objCar.Speed)

    '    'Accelerate
    '    objCar.Accelerate(5)

    '    'Report the New speed
    '    Console.WriteLine("The car's speed is now:")
    '    Console.WriteLine(objCar.Speed)

    '    'Wait for input from the user
    '    Console.ReadLine()

    '    'Dispose of the object
    '    objCar.Dispose()
    '    objCar = Nothing
    'End Sub

    'DisplayCarDetails—procedure that displays a car's details
    Sub DisplayCarDetails(ByVal theCar As CarPerformance.Car)
        'Display the details of the car
        Console.WriteLine("Color:" & theCar.Color)
        Console.WriteLine("Number of doors:" & theCar.NumberOfDoors)
        Console.WriteLine("Current speed:" & theCar.Speed)
        Console.WriteLine("Car Horsepower:" & theCar.HorsePower)
        Console.WriteLine("Acceleration rate: " &
                            theCar.CalculateAccelerationRate)
    End Sub

    'DisplaySportsCarDetails—procedure that displays a sports car's details
    Sub DisplaySportsCarDetails(ByVal theCar As SportsCar)
        'Display the details of the sports car
        Console.WriteLine()
        'Console.WriteLine("Sports Car Horsepower:" & theCar.HorsePower)
        Console.WriteLine("Sports Car Weight:" & theCar.Weight)
        Console.WriteLine("Power to Weight Ratio:" & theCar.GetPowerToWeightRatio)
    End Sub
End Module
