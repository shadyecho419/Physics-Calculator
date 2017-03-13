Public Class MechAndPropOfMatter

    Private _CircularAccel As Double
    Private _AngularVelocity As Double
    Private _LengthOfArc As Double
    Private _Period As Double
    Private _Velocity As Double
    Private _Acceleration As Double
    Private _Distance As Double
    Private _FinalVelocity As Double
    Private _InitialVelocity As Double
    Private _Time As Double
    Private _DensityOfPlanet As Double
    Private _GravitationalForce As Double
    Private _GravitationalPotential As Double
    Private _MassOfPlanet As Double
    Private _Force As Double
    Private _KineticEnergy As Double
    Private _Momentum As Double
    Private _Power As Double
    Private _Work As Double
    Private _Energy As Double
    Private _TensileStressAndStrain As Double
    Private _YoungModulus As Double
    Private _Pressure As Double
    Private _Density As Double
    Private _Torque As Double
    Const _GConstant As Double = 0.000000000067

    'calculate circular acceleration
    Public Sub CalcCircularAccel(ByVal _Radius As Double, ByVal _Vel As Double)
        _CircularAccel = (_Vel ^ 2) / _Radius
    End Sub
    'return circular acceleration value
    Public ReadOnly Property CalcCircularAccelResult() As Double
        Get
            Return _CircularAccel
        End Get
    End Property

    'calculate circular acceleration using angular velocity
    Public Sub CalcCircularAccelUsnAngVel(ByVal _Radius As Double, ByVal _AngVel As Double)
        _CircularAccel = _Radius * (_AngVel ^ 2)
    End Sub
    'return circular acceleration using angular velocity value
    Public ReadOnly Property CalcCircularAccelUsnAngVelResult() As Double
        Get
            Return _CircularAccel
        End Get
    End Property

    'calculate angular velocity
    Public Sub CalcAngularVel(ByVal _Angle As Double, ByVal _Time As Double)
        _AngularVelocity = _Angle / _Time
    End Sub
    'return angular velocity value
    Public ReadOnly Property CalcAngularVelResult() As Double
        Get
            Return _AngularVelocity
        End Get
    End Property

    'calculate length of an arc
    Public Sub CalcLenOfArc(ByVal _Radius As Double, ByVal _Angle As Double)
        _LengthOfArc = _Radius * _Angle
    End Sub
    'return length of an arc value
    Public ReadOnly Property CalcLenOfArcResult() As Double
        Get
            Return _LengthOfArc
        End Get
    End Property

    'calculate period (T)
    Public Sub CalcPeriod(ByVal _AngularVel As Double)
        _Period = (2 * System.Math.PI) / _AngularVel
    End Sub
    'return period (T) value
    Public ReadOnly Property CalcPeriodResult() As Double
        Get
            Return _Period
        End Get
    End Property

    'calculate velocity of a rotating object
    Public Sub CalcVelOfRotatingObj(ByVal _Radius As Double, ByVal _AngularVel As Double)
        _Velocity = _AngularVel * _Radius
    End Sub
    'return velocity of a rotating object value
    Public ReadOnly Property CalcVelOfRotatingObjResult() As Double
        Get
            Return _Velocity
        End Get
    End Property

    'calculate acceleration given U, T, and V
    Public Sub CalcAccelGVUTV(ByVal _InitialVel As Double, ByVal _FinalVel As Double, ByVal _Time As Double)
        _Acceleration = ((_FinalVel - _InitialVel) / _Time)
    End Sub
    'return acceleration given U, T, and V value
    Public ReadOnly Property CalcAccelGVUTVResult() As Double
        Get
            Return _Acceleration
        End Get
    End Property

    'calculate Acceleration given S, U and T 
    Public Sub CalcAccelGVSUT(ByVal _InitialVel As Double, ByVal _Distance As Double, ByVal _Time As Double)
        _Acceleration = ((2 * (_Distance - (_InitialVel * _Time)) / (_Time ^ 2)))
    End Sub
    'return Acceleration given S, U and T  value
    Public ReadOnly Property CalcAccelGVSUTResult() As Double
        Get
            Return _Acceleration
        End Get
    End Property

    'calculate Distance travelled given T, U And A
    Public Sub CalcDistGVTUA(ByVal _InitialVel As Double, ByVal _Acceleration As Double, ByVal _Time As Double)
        _Distance = ((_InitialVel * _Time) + (0.5 * (_Acceleration * (_Time ^ 2))))
    End Sub
    'return Distance travelled given T, U And A  value
    Public ReadOnly Property CalcDistGVTUAResult() As Double
        Get
            Return _Distance
        End Get
    End Property

    'calculate Distance travelled given U, V And T 
    Public Sub CalcDistGVUVT(ByVal _InitialVel As Double, ByVal _FinalVel As Double, ByVal _Time As Double)
        _Distance = ((0.5 * (_InitialVel + _FinalVel) * _Time))
    End Sub
    'return Distance travelled given U, V And T  value
    Public ReadOnly Property CalcDistGVUVTResult() As Double
        Get
            Return _Distance
        End Get
    End Property

    'calculate Final Velocity given U, A and S
    Public Sub CalcFinalVelGVUAS(ByVal _InitialVel As Double, ByVal _Accel As Double, ByVal _Displacement As Double)
        _FinalVelocity = (Math.Sqrt((_InitialVel ^ 2) + (2 * _Accel * _Displacement)))
    End Sub
    'return Final Velocity given U, A and S value
    Public ReadOnly Property CalcFinalVelGVUASResult() As Double
        Get
            Return _FinalVelocity
        End Get
    End Property

    'calculate Final Velocity given A, T and U
    Public Sub CalcFinalVelGVATU(ByVal _InitialVel As Double, ByVal _Acceleration As Double, ByVal _Time As Double)
        _FinalVelocity = _InitialVel + (_Acceleration * _Time)
    End Sub
    'return Final Velocity given A, T and U value
    Public ReadOnly Property CalcFinalVelGVATUResult() As Double
        Get
            Return _FinalVelocity
        End Get
    End Property

    'calculate Initial Velocity given V, A and T
    Public Sub CalcInitialVelGVVAT(ByVal _FinalVel As Double, ByVal _Acceleration As Double, ByVal _Time As Double)
        _InitialVelocity = _FinalVel - (_Acceleration * _Time)
    End Sub
    'return Initial Velocity given V, A and T value
    Public ReadOnly Property CalcInitialVelGVVATResult() As Double
        Get
            Return _InitialVelocity
        End Get
    End Property

    'calculate Time taken given U, A and V 
    Public Sub CalcTimeGVUAV(ByVal _InitialVel As Double, ByVal _Acceleration As Double, ByVal _FinalVel As Double)
        _Time = (_FinalVel - _InitialVel) / _Acceleration
    End Sub
    'return Time taken given U, A and V value
    Public ReadOnly Property CalcTimeGVUAVResult() As Double
        Get
            Return _Time
        End Get
    End Property

    'calculate density of a planet
    Public Sub CalcDensOfPlanet(ByVal _AccelDueToG As Double, ByVal _Radius As Double)
        _DensityOfPlanet = (3 * _AccelDueToG) / (4 * System.Math.PI * _Radius * _GConstant)
    End Sub
    'return density of a planet value
    Public ReadOnly Property CalcDensOfPlanetResult() As Double
        Get
            Return _DensityOfPlanet
        End Get
    End Property

    'calculate Gravitational Force (F)(Newtons)
    Public Sub CalcGravForce(ByVal _mass As Double, ByVal _Mass2 As Double, ByVal _Radius As Double)
        _GravitationalForce = (_GConstant * _mass * _Mass2) / (_Radius ^ 2)
    End Sub
    'return Gravitational Force (F)(Newtons) value
    Public ReadOnly Property CalcGravForceResult() As Double
        Get
            Return _GravitationalForce
        End Get
    End Property

    'calculate Gravitational potential
    Public Sub CalcGravPotential(ByVal _mass As Double, ByVal _Distance As Double)
        _GravitationalPotential = -(_GConstant * _mass) / _Distance
    End Sub
    'return Gravitational potential value
    Public ReadOnly Property CalcGravPotentialResult() As Double
        Get
            Return _GravitationalPotential
        End Get
    End Property

    'calculate mass of planet
    Public Sub CalcMassOfPlanet(ByVal _Gravity As Double, ByVal _Radius As Double)
        _MassOfPlanet = (_Gravity * _Radius ^ 2) / _GConstant
    End Sub
    'return mass of planet value
    Public ReadOnly Property CalcMassOfPlanetResult() As Double
        Get
            Return _MassOfPlanet
        End Get
    End Property

    'calculate period of satellite in its orbit
    Public Sub CalcPeriodOfSatOrbit(ByVal _Gravity As Double, ByVal _Radius As Double, ByVal SatDistance As Double)
        _Period = System.Math.Sqrt(((4 * (System.Math.PI ^ 2) * SatDistance ^ 3) / (_Gravity * _Radius ^ 2)))
    End Sub
    'return period of satellite in its orbit
    Public ReadOnly Property CalcPeriodOfSatOrbitResult() As Double
        Get
            Return _Period
        End Get
    End Property

    'calculate force acting on constant mass
    Public Sub CalcForceOnConstMass(ByVal _Mass As Double, ByVal _Acceleration As Double)
        _Force = _Mass * _Acceleration
    End Sub
    'return force acting on constant mass value
    Public ReadOnly Property CalcForceOnConstMassResult() As Double
        Get
            Return _Force
        End Get
    End Property

    'calculate force due to momentum change
    Public Sub CalcForceDueToMomentum(ByVal _Momentum As Double, ByVal _Time As Double)
        _Force = _Momentum / _Time
    End Sub
    'return force due to momentum change value
    Public ReadOnly Property CalcForceDueToMomentumResult() As Double
        Get
            Return _Force
        End Get
    End Property

    'calculate gravitational potential energy
    Public Sub CalcGPE(ByVal _Mass As Double, ByVal _Height As Double)
        _GravitationalPotential = _Mass * 9.81 * _Height
    End Sub
    'return gravitational potential energy value
    Public ReadOnly Property CalcGPEResult() As Double
        Get
            Return _GravitationalPotential
        End Get
    End Property

    'calculate kinetic energy
    Public Sub CalcKE(ByVal _Mass As Double, ByVal _Velocity As Double)
        _KineticEnergy = 0.5 * _Mass * _Velocity ^ 2
    End Sub
    'return kinetic energy value
    Public ReadOnly Property CalcKEResult() As Double
        Get
            Return _KineticEnergy
        End Get
    End Property

    'calculate momentum of a body
    Public Sub CalcMomentum(ByVal _Mass As Double, ByVal _Velocity As Double)
        _Momentum = _Mass * _Velocity
    End Sub
    'return momentum of a body value
    Public ReadOnly Property CalcMomentumResult() As Double
        Get
            Return _Momentum
        End Get
    End Property

    'calculate power
    Public Sub CalcPower(ByVal _Force As Double, ByVal _Displacement As Double, ByVal _Time As Double)
        _Power = (_Force * _Displacement) / _Time
    End Sub
    'return power value
    Public ReadOnly Property CalcPowerResult() As Double
        Get
            Return _Power
        End Get
    End Property

    'calculate work done
    Public Sub CalcWorkDone(ByVal _Force As Double, ByVal _Displacement As Double)
        _Work = (_Force * _Displacement)
    End Sub
    'return work done value
    Public ReadOnly Property CalcWorkDoneResult() As Double
        Get
            Return _Work
        End Get
    End Property

    'calculate work done with force at an angle
    Public Sub CalcWorkDoneWitAngle(ByVal _Force As Double, ByVal _Angle As Double, ByVal _Displacement As Double)
        _Work = (_Force * System.Math.Cos(_Angle) * _Displacement)
    End Sub
    'return work done with force at an angle value
    Public ReadOnly Property CalcWorkDoneWitAngleResult() As Double
        Get
            Return _Work
        End Get
    End Property

    'calculate energy stored in a wire using young modulus of elasticity
    Public Sub CalcEnergyUsingYoungMod(ByVal _Modulus As Double, ByVal _Area As Double, ByVal _Extension As Double, ByVal _Length As Double)
        _Energy = (0.5 * _Modulus * _Area * _Extension ^ 2) / _Length
    End Sub
    'return energy stored in a wire using young modulus of elasticity value
    Public ReadOnly Property CalcEnergyUsingYoungModResult() As Double
        Get
            Return _Energy
        End Get
    End Property
    'calculate energy stored in a wire using average force
    Public Sub CalcEnergyUsingForce(ByVal _Force As Double, ByVal _Extension As Double)
        _Energy = 0.5 * _Force * _Extension
    End Sub
    'return energy stored in a wire using average force value
    Public ReadOnly Property CalcEnergyUsingForceResult() As Double
        Get
            Return _Energy
        End Get
    End Property

    'calculate tensile stress
    Public Sub CalcTensileStress(ByVal _Force As Double, ByVal _Area As Double)
        _TensileStressAndStrain = _Force / _Area
    End Sub
    'return tensile stress value
    Public ReadOnly Property CalcTensileStressResult() As Double
        Get
            Return _TensileStressAndStrain
        End Get
    End Property

    'calculate tensile strain
    Public Sub CalcTensileStrain(ByVal _Extension As Double, ByVal _Length As Double)
        _TensileStressAndStrain = _Extension / _Length
    End Sub
    'return tensile strain value
    Public ReadOnly Property CalcTensileStrainResult() As Double
        Get
            Return _TensileStressAndStrain
        End Get
    End Property

    'calculate young modulus of elasticity
    Public Sub CalcYoungMod(ByVal _Force As Double, ByVal _Area As Double, ByVal _Extension As Double, ByVal _Length As Double)
        _YoungModulus = (_Force / _Area) / (_Extension / _Length)
    End Sub
    'return young modulus of elasticity value
    Public ReadOnly Property CalcYoungModResult() As Double
        Get
            Return _YoungModulus
        End Get
    End Property

    'calculate centripetal acceleration
    Public Sub CalcCentiAccel(ByVal _AngularVel As Double, ByVal _Distance As Double)
        _Acceleration = -(_AngularVel ^ 2) * (_Distance)
    End Sub
    'return centripetal acceleration value
    Public ReadOnly Property CalcCentiAccelResult() As Double
        Get
            Return _Acceleration
        End Get
    End Property

    'calculate period of oscillation
    Public Sub CalcPeriodOfOsc(ByVal _Frequency As Double)
        _Period = 1 / _Frequency
    End Sub
    'return period of oscillation value
    Public ReadOnly Property CalcPeriodOfOscResult() As Double
        Get
            Return _Period
        End Get
    End Property


    'calculate frequency of oscillation
    Public Sub CalcFrequencyOfOsc(ByVal _Period As Double)
        _Period = 1 / _Period
    End Sub
    'return frequency of oscillation value
    Public ReadOnly Property CalcFrequencyOfOscResult() As Double
        Get
            Return _Period
        End Get
    End Property

    'calculate maximum velocity
    Public Sub CalcMaximumVel(ByVal _AngularVel As Double, ByVal _MaxAmp As Double)
        _Velocity = _AngularVel * _MaxAmp
    End Sub
    'return maximum velocity value
    Public ReadOnly Property CalcMaximumVelResult() As Double
        Get
            Return _Velocity
        End Get
    End Property

    'calculate period of simple harmonic motion
    Public Sub CalcPeriodSHM(ByVal _AngularVel As Double)
        _Period = (2 * System.Math.PI) / _AngularVel
    End Sub
    'return period of simple harmonic motion value
    Public ReadOnly Property CalcPeriodSHMResult() As Double
        Get
            Return _Period
        End Get
    End Property

    'calculate velocity at any instant
    Public Sub CalcVelocityAtAnyInst(ByVal _AngularVel As Double, ByVal _MaxAmp As Double, ByVal _DistanceFromY As Double)
        _Velocity = ""
    End Sub
    'return velocity at any instant value
    Public ReadOnly Property CalcVelocityAtAnyInstResult() As Double
        Get
            Return _Velocity
        End Get
    End Property

    'calculate pressure
    Public Sub CalcPressure(ByVal _Force As Double, ByVal _Area As Double)
        _Pressure = _Force / _Area
    End Sub
    'return pressure value
    Public ReadOnly Property CalcPressureResult() As Double
        Get
            Return _Pressure
        End Get
    End Property

    'calculate density
    Public Sub CalcDensity(ByVal _Mass As Double, ByVal _Volume As Double)
        _Density = _Mass / _Volume
    End Sub
    'return density value
    Public ReadOnly Property CalcDensityResult() As Double
        Get
            Return _Density
        End Get
    End Property

    'calculate pressure in a liquid
    Public Sub CalcPressureInLiquid(ByVal _Density As Double, ByVal _Acceleration As Double, ByVal _Depth As Double)
        _Pressure = _Density * _Acceleration * _Depth
    End Sub
    'return pressure in a liquid value
    Public ReadOnly Property CalcPressureInLiquidResult() As Double
        Get
            Return _Pressure
        End Get
    End Property

    'calculate torque
    Public Sub CalcTorque(ByVal _Force As Double, ByVal _PerpDistance As Double)
        _Torque = _Force * _PerpDistance
    End Sub
    'return torque value
    Public ReadOnly Property CalcTorqueResult() As Double
        Get
            Return _Torque
        End Get
    End Property
End Class
