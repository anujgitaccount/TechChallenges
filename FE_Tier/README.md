# cft resources used in this tier 

* VPC
* Route Table
* IG
* IG attachment to the VPC

* 2 Public Subnets
* ASG for Private Subnets
* Scaling Policy for Private Subnets

* 4 Private Subnets
* ASG for Public Subnets
* Scaling Policy for Public Subnet
* Route Table for Public Subnets
* Public Subnets association to the Route Table

* Security group ( HTTP & SSH to open to 0.0.0.0/0 )
* Launch Template with Bootstrap script to install & launch Apache -- user data config
