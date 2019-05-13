<?php
require 'users.php';

class Post extends User
{ 


    public function postInfo() // function to be able to see the current database information 
        {
            $conn = $this->connect();
            $sql='SELECT * FROM posts WHERE id_gebruiker = :id';
            $stmt = $conn->prepare($sql);
            $stmt->bindParam(":id", $_SESSION["id"]);
            $stmt->execute();
            $data = $stmt->fetchAll(PDO::FETCH_ASSOC);
            return $data;
        }


    public function userPost($datum, $post) // putting a post into the database
        {
            $conn = $this->connect(); //making connection
            $sql='INSERT INTO posts (id_gebruiker, post, datum) VALUES (:id, :post, :datum)'; // put info in database Post
            $stmt = $conn->prepare($sql);
            $stmt->bindParam(":id", $_SESSION["id"]);
            $stmt->bindParam(':datum',$datum);
            $stmt->bindParam(':post',$post);
        
            if ($stmt->execute())
            {
                $conn = NULL;
                header('location: ../mypage.php');
            }
        }
}
?>