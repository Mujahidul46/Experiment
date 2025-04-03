import { Component } from '@angular/core';
import { SpeechRecognitionService } from '../speech-recognition.service'

@Component({
  selector: 'app-text-to-speech',
  imports: [],
  templateUrl: './text-to-speech.component.html',
  styleUrl: './text-to-speech.component.css'
})
export class TextToSpeechComponent {
  transcript: string = '';

  constructor(private speechRecognitionService: SpeechRecognitionService) {
    this.speechRecognitionService.transcript = this.transcript;//what?
  }

  startListening() {
    this.speechRecognitionService.startListening();
  }

  stopListening() {
    this.speechRecognitionService.stopListening();
  }
}
