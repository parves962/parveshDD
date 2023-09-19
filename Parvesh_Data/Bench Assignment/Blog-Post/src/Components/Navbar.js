import { useState } from "react";
import { Link } from "react-router-dom";
function Navbar(props) {
  const [PageNo, setPageNo] = useState(props.pageno);

  return (
    <div>
      <nav className="navbar navbar-light">
        <div className="container-fluid">
          <h1 className="heading">Browsing Posts</h1>
        </div>
      </nav>
    </div>
  );
}

export default Navbar;
