import { Injectable, NgZone } from '@angular/core';

// uses the web speech API

@Injectable({
  providedIn: 'root', // makes the service accessible throughout the app
})
export class SpeechRecognitionService {
  recognition: any; // speech recognition instance
  isListening = false;
  transcript = ''; // stores text

  constructor(private zone: NgZone) {
    const SpeechRecognition = // uses the web speech API (aka where the magic happens)
      (window as any).SpeechRecognition || (window as any).webkitSpeechRecognition; // checks if the web speech API is available in browser

    if (!SpeechRecognition) {
      alert('Speech recognition is not supported in this browser.'); // safari/firefox wont be supported
      return;
    }

    this.recognition = new SpeechRecognition();
    this.recognition.continuous = true; // continues listening "forever" unless manually stopped
    this.recognition.interimResults = true; 
    this.recognition.lang = 'en-US';

    this.recognition.onresult = (event: any) => {
      let updatedSpeech = ''; // temportary speech storage (updated over time) e.g. "Hello" "Hello, how are" "Hello, how are you"
      for (let i = event.resultIndex; i < event.results.length; i++) {
        updatedSpeech += event.results[i][0].transcript;
      }
      this.zone.run(() => {
        this.transcript = updatedSpeech;
      });
    };
  }

  startListening() {
    if (!this.isListening) {
      this.transcript = ''; // empty the transcript so it doesnt merge with previous speech
      this.recognition.start();
      this.isListening = true;
    }
  }

  stopListening() {
    if (this.isListening) {
      this.recognition.stop();
      this.isListening = false;
    }
  }
}
