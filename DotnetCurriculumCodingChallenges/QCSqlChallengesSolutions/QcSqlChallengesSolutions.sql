--Question ID #1266454 

CREATE TABLE department_revenue (
    id int,
    department_id int,
    year int,
    revenue int
);

INSERT INTO department_revenue values(1,1,2018,60);
INSERT INTO department_revenue values(2,1,2021,40);
INSERT INTO department_revenue values(3,1,2020,70);
INSERT INTO department_revenue values(4,2,2021,-10);
INSERT INTO department_revenue values(5,3,2018,20);
INSERT INTO department_revenue values(6,3,2016,-40);
INSERT INTO department_revenue values(7,4,2021,50);

select department_id from department_revenue 
group by department_id
having SUM(revenue) > 0;