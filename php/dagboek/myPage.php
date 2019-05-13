<?php   
    session_start(); 
    require('src/post.php');
    $post = new Post();
    $data = $post->postInfo();
    ?>

<html>
    <head>
            <title>My Page</title>
            <link rel="stylesheet" href="css/stylePost.css">
            <meta name="viewport" content="width=device-width, initial-scale=1">
    </head>
        <body>
            <div id="navigation">
                <ul>
                        <li><a href="mypage.php">My page</a></li>
                        <li><a href="settings.php">Settings</a></li>
                        <li class="logoutnav"><a href="logout.php">Logout</a></li>
                </ul>
            </div>
                <div class="wrapper">
                    <h1>Welcome to your personal diary.</h1>
                    <form action='forms/postForm.php' method="POST">
                        <div class="postcontainer">
                            <h2>What did you do today?</h2>
                            <p><textarea class="comment" placeholder="write about your day" name='post' required></textarea></p>
                            <input type='submit' name="postbutton" value='Upload my story' class="uploadbtn">
                        </div>
                    </form>
                        <div class="diarybook">
                            <h2> Click your diary to show your stories. </h2>
                            <!-- Trigger/Open The Modal -->       
                            <input type="image" id="myBtn" src="images/dagboek.png" alt="Submit" />
                        </div>
                            <!-- The Modal -->
                        <div id="myModal" class="modal">
                            <!-- Modal content -->
                        <div class="modal-content">
                            <span class="close">&times;</span>
                                <?php 
                                foreach($data as $post)
                                {
                                    print "<div><p class='datumtext'>" . $post["datum"] ."</p></div>";
                                    print "<div><p class='diarytext'>" . $post["post"] ."</p></div>";
                                }
                                ?>
                        </div>
                        </div>
            <script>
                // Get the modal
                var modal = document.getElementById('myModal');
                
                // Get the button that opens the modal
                var btn = document.getElementById("myBtn");
                
                // Get the <span> element that closes the modal
                var span = document.getElementsByClassName("close")[0];
                
                // When the user clicks the button, open the modal 
                btn.onclick = function() 
                    {
                        modal.style.display = "block";
                    }
                // When the user clicks on <span> (x), close the modal
                span.onclick = function() 
                    {
                        modal.style.display = "none";
                    }
                // When the user clicks anywhere outside of the modal, close it
                window.onclick = function(event) 
                    {
                        if (event.target == modal) 
                            {
                                modal.style.display = "none";
                            }
                    }
            </script>
        </div>
    </body>
</html>