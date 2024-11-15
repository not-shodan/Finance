
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
