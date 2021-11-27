using System;

public class GameViewModel
{
    public const int firstUpgradeCostValue = 100;
    public const int firstUpgradeIncreasingValue = 1;
    public const int secondUpgradeCostValue = 250;
    public const int secondUpgradeIncreasingValue = 5;
    public const int upgradeTimerCostValue = 2500;
    public const int TimerCounterIncreaserValue = 1;

    private int currentCounter;
    
    private int clickFirstUpgradeCost; 
    private int clickSecondUpgradeCost;
    private int timerUpgradeCost;
    
    private int counterIncreaser;
    private int timerCounterIncreaser;
    private bool isTimerEnabled;

    public GameViewModel()
    {
        this.currentCounter = 0;
        this.clickFirstUpgradeCost = 100;
        this.clickSecondUpgradeCost = 250;
        this.timerUpgradeCost = 25;
        this.counterIncreaser = 1;
        this.timerCounterIncreaser = 0;
        this.isTimerEnabled = false;

    }

    public int CurrentCounter
    {
        get
        {
            return currentCounter;
        }

        set
        {
            currentCounter = value;
        }
    }

    public int ClickFirstUpgradeCost
    {
        get
        {
            return clickFirstUpgradeCost;
        }

        set
        {
            clickFirstUpgradeCost = value;
        }
    }

    public int ClickSecondUpgradeCost
    {
        get
        {
            return clickSecondUpgradeCost;
        }

        set
        {
            clickSecondUpgradeCost = value;
        }
    }

    public int TimerUpgradeCost
    {
        get
        {
            return timerUpgradeCost;
        }

        set
        {
            timerUpgradeCost = value;
        }
    }

    public int CounterIncreaser
    {
        get
        {
            return counterIncreaser;
        }

        set
        {
            counterIncreaser = value;
        }
    }

    public int TimerCounterIncreaser
    {
        get
        {
            return timerCounterIncreaser;
        }

        set
        {
            timerCounterIncreaser = value;
        }
    }

    public bool IsTimerEnabled
    {
        get
        {
            return isTimerEnabled;
        }

        set
        {
            isTimerEnabled = value;
        }
    }
    public void increaseCounter() => currentCounter += counterIncreaser;

    public void increasingCounterIncreaser(int newValue)
    {
        counterIncreaser += newValue;
    }
}
