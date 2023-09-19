import logo from "./logo.svg";
import "./App.css";
import { useState } from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./Components/Home";
import Post from "./Components/Post";
import Navbar from "./Components/Navbar";
import List from "./Components/list";
import Edit from "./Components/Edit";
import { Provider } from "react-redux";
import store from "./redux/store";
function App() {
  return (
    <Provider store={store}>
      <BrowserRouter>
        <Navbar />
        <br></br>

        <Routes>
          <Route path="/list/:id" element={<List />} />
          {/* <Route path="/list/:data" element={<List />} /> */}
          <Route path="/post" element={<Post />} />
          <Route path="/" element={<Home />} />
          <Route path="/edit/:id" element={<Edit />} />
          {/* <Route path="/Navbar" element={<Navbar />}></Route> */}
        </Routes>
      </BrowserRouter>
    </Provider>

    // <Home />
    // <h1>hyy there</h1>
  );
}

export default App;
