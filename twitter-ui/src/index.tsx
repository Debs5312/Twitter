import ReactDOM from "react-dom/client";
import { RouterProvider } from "react-router-dom";
import "semantic-ui-css/semantic.min.css";
import { router } from "./Router/Routes";
import { store, StoreContext } from "./Stores/CentralStore";

const root = ReactDOM.createRoot(
  document.getElementById("root") as HTMLElement
);
root.render(
  <StoreContext.Provider value={store}>
    <RouterProvider router={router} />
  </StoreContext.Provider>
);
