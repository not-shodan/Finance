
## Risk Formulas
- TRM (Treasury and Risk Management)
- FOREIGN EXCHANGE RISK
- INTEREST SIMULATION
- INTEREST RATE RISK ( data and analysis on yield curves and relevant credit spreads)
- CREDIT RISK estimates for default likelihood, issuer credit rating and implied 5-year CDS spreads.
- Multi-Asset Risk (MARS)
- Analyze the sensitivity of your hedges to interest rate or FX movements via DV01 and FX01 calculations
- Calculate your portfolio’s Value at Risk (VaR) using the market standard historical VaR method


Identify Skews


PORTFOLIO VALUE-AT-RISK

 1. Parametric VaR
 2. Historical VaR
 3. Monte Carlo VaR


TRM Risk supports
curve bootstrapping
FX rates
swap valuation engine (SWPM)
FX valuation engine (OVML)


Stress Matrix Pricing (SMP)


.

.

.

<img width="546" alt="image" src="https://github.com/user-attachments/assets/58675964-239d-4011-a35e-e2e4146a2bfe">



## Classes
- Client
- Portfolio
- Grid
- Simulations
- Reports

## Client
- account_number
- client_name
- total_position (sum of global_portfolio + local_portfolio)

## Portfolio
- portfolio_number
- client_number
- portfolio_type (local or global)
- stocks

## Grid
- stock_name
- last_price
- last_change
- last_six
- last_twelve

Simulations
- something

Reports
- return_performance





## Table of Contents
in progress


## How does this code work?
- Will be available on the through web interface
- User can import a csv and this data will be save to a Database
- All changes on 'client' account will be saved directly to db
- Separated menus, to run simulations, plot graph, getinfo


## Features
- return holidays
- returnPrice (return a table or single stock quote and last close/price)
- returnFedDecisions(historically)
- returnDXY
- returnDOLBRL(B3)
- returnBrazilianIterestRates(BC, historically)


## Future features
- balance sheet analytics
- hedging strategies
- interest rate pricing & risk management
- trade execution
- funding optimization
- liquidity risk management
- cash & collateral management
