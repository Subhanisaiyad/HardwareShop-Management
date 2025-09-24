#!/bin/bash

# This script calculates simple interest

# Taking user input
echo "Enter the principal amount:"
read principal

echo "Enter the rate of interest (per year):"
read rate

echo "Enter the time period (in years):"
read time

# Calculating simple interest
interest=$(( (principal * rate * time) / 100 ))

# Displaying the result
echo "The Simple Interest is: $interest"
