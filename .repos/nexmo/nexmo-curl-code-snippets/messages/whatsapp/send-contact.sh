#!/usr/bin/env bash

source "../../config.sh"
source "../../jwt.sh"

curl -X POST \
  https://api.nexmo.com/v0.1/messages \
  -H 'Authorization: Bearer' $JWT \
  -H 'Content-Type: application/json' \
  -d '{
  "from": {
    "type": "whatsapp",
    "number": "'$WHATSAPP_NUMBER'"
  },
  "to": {
    "type": "whatsapp",
    "number": "'$TO_NUMBER'"
  },
  "message": {
    "content": {
      "type": "custom",
      "custom": {
        "type": "contacts",
        "contacts": [
          {
            "addresses": [
              {
                "city": "Menlo Park",
                "country": "United States",
                "country_code": "us",
                "state": "CA",
                "street": "1 Hacker Way",
                "type": "HOME",
                "zip": "94025"
              },
              {
                "city": "Menlo Park",
                "country": "United States",
                "country_code": "us",
                "state": "CA",
                "street": "200 Jefferson Dr",
                "type": "WORK",
                "zip": "94025"
              }
            ],
            "birthday": "2012-08-18",
            "emails": [
              {
                "email": "test@fb.com",
                "type": "WORK"
              },
              {
                "email": "test@whatsapp.com",
                "type": "WORK"
              }
            ],
            "name": {
              "first_name": "John",
              "formatted_name": "John Smith",
              "last_name": "Smith"
            },
            "org": {
              "company": "WhatsApp",
              "department": "Design",
              "title": "Manager"
            },
            "phones": [
              {
                "phone": "+1 (940) 555-1234",
                "type": "HOME"
              },
              {
                "phone": "+1 (650) 555-1234",
                "type": "WORK",
                "wa_id": "16505551234"
              }
            ],
            "urls": [
              {
                "url": "https://www.facebook.com",
                "type": "WORK"
              }
            ]
          }
        ]
      }
    }
  }
}'
