const imageURL = "./Images/background.jpg";

export default function HomePage() {
  return (
    <div
      style={{
        backgroundImage: `url(${imageURL})`,
        backgroundPosition: "center",
        backgroundSize: "cover",
        backgroundRepeat: "no-repeat",
        height: "100vh",
        width: "100%",
      }}
    ></div>
  );
}
