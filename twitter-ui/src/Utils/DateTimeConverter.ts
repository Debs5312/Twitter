const monthPicker = [
  "January",
  "February",
  "March",
  "April",
  "May",
  "June",
  "July",
  "August",
  "September",
  "October",
  "November",
  "December",
];

const date = (data: string) => {
  const [year, month, day] = data.split("T")[0].split("-");
  const newdate = monthPicker[Number(month) - 1] + " " + day + ", " + year;
  return newdate;
};

export default date;
